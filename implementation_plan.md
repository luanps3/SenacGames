# Objetivo

Corrigir e aprimorar o sistema de alternância de temas (Dark Mode / Light Mode) em toda a aplicação SenacGames. O sistema atual possui cores "hardcoded" que quebram no Light Mode, problemas de contraste no Hero Banner e botões/filtros com comportamento inconsistente. O objetivo é estabelecer um sistema de design tokens global utilizando CSS Variables.

## Open Questions

Nenhuma no momento. Os requisitos estão bem claros e os componentes afetados já foram identificados no CSS e nas Views Razor.

## Proposed Changes

### CSS (Estilos e Variáveis)

#### [MODIFY] `SenacGames.UI/wwwroot/css/site.css`
- **Variáveis CSS (`:root` e `[data-theme="dark"]`)**: 
  - Adicionar as variáveis `--hero-title-start` e `--hero-title-end` para resolver o problema do título invisível no Light Mode.
  - Adicionar as variáveis `--secondary-transparent` e `--secondary-transparent-border` para unificar os fundos semitransparentes nos "badges" e ícones que atualmente possuem o `rgba()` fixo.
- **Hero Banner**: Remover a propriedade `background: linear-gradient(...)` estática do `h1` e substituí-la pelas novas variáveis (`--hero-title-start` e `--hero-title-end`). Remover as sombras azuis do botão e usar as variáveis.
- **Badges (`.badge-category`, `.badge-featured`)**: Substituir as cores com `rgba` fixos (branco transparente) pelas variáveis de container para se adaptarem bem no modo claro.
- **Filtros (`.category-filter .btn`)**: Remover a sombra hardcoded em ciano e aplicar `var(--shadow-glow)` ou uma variável adequada com contraste dinâmico.
- **Ícones de Estatística (`.stat-icon.primary`)**: Substituir o `rgba` por variáveis.

### JavaScript (Persistência e Funcionalidade)

#### [MODIFY] `SenacGames.UI/wwwroot/js/theme.js`
- **Atualização de Ícones**: Ao mudar para o tema 'light', a cor do ícone (`#3e4453`) será substituída pela variável `var(--on-surface-variant)` para garantir total alinhamento com a paleta.

### Views Razor (Remoção de Classes Hardcoded)

#### [MODIFY] `SenacGames.UI/Views/Home/Index.cshtml`
- **Card de Lançamentos**: Onde a imagem de cover não existe, remover `background: linear-gradient(135deg, #004c97, #0066cc);` e `text-white`. Substituir por `background: var(--surface-container-high);` e ícone com `color: var(--on-surface-variant);` (para seguir o padrão usado nas outras páginas).

#### [MODIFY] `SenacGames.UI/Views/Games/Details.cshtml`
- **Banner de Capa (Placeholder)**: Remover o background estático `rgba(255,255,255,0.1)` e `text-white` do contêiner de imagem de capa alternativa e substituir por variáveis do tema (`var(--surface-container-high)`).

#### [MODIFY] `SenacGames.UI/Views/Shared/_AdminLayout.cshtml`
- **Sidebar Logout**: Remover o estilo `style="color: rgba(255,255,255,0.7) !important;"` que tornava o botão "Sair" invisível no tema claro (fundo branco).

## Verification Plan

### Teste Manual de Consistência
- Alternar para o Light Mode e navegar entre a Home, Catálogo de Games, Detalhes de Jogo e Dashboard Admin. O tema não deverá "piscar" para dark (o `theme.js` sendo carregado na `<head>` já mitiga isso de forma correta, mas a ausência de estilos quebrados confirmará o sucesso).
- Verificar o título do Hero Banner na Home para assegurar a legibilidade e contraste apropriados no Light Mode.
- Verificar os modais, filtros na página "Catálogo de Games" (`/Games`) para ver se as cores de fundo continuam suaves e consistentes com o tema ativo.
- Fazer logout e login e garantir que o layout dos formulários mantém o estado do `LocalStorage`.
