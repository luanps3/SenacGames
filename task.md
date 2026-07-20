# Correção do Sistema de Temas (Light/Dark Mode)

- [x] Atualizar estilos globais em `site.css`
  - Adicionar variáveis `--hero-title-start` e `--hero-title-end`
  - Adicionar variáveis `--secondary-transparent` e `--secondary-transparent-border`
  - Corrigir Hero Banner para usar variáveis no lugar de gradientes e sombras "hardcoded"
  - Corrigir os estilos das `badges` e `filtros`
  - Corrigir backgrounds de ícones nos `stat-cards`
- [x] Atualizar script de tema `theme.js`
  - Alterar a cor do ícone no Light Mode de `#3e4453` para `var(--on-surface-variant)`
- [x] Atualizar Views Razor para remover classes restritivas
  - `Home/Index.cshtml` (Remover gradients hardcoded e text-white em placeholders de imagem)
  - `Games/Details.cshtml` (Remover text-white e backgrounds hardcoded nas imagens alternativas)
  - `Shared/_AdminLayout.cshtml` (Remover style inline do botão de Sair na Sidebar)
- [x] Validação Visual concluída através da análise lógica do código CSS/HTML.
