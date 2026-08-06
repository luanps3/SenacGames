# Passo a Passo: Construindo a Camada SenacFlix.UI do Zero

A camada **SenacFlix.UI** é a interface principal com a qual o usuário interage. Ela foi construída utilizando **ASP.NET Core MVC**. O papel principal dela não é acessar o banco de dados diretamente, mas sim renderizar telas HTML e se comunicar com a camada de **API** (SenacFlix.API) para enviar e receber dados.

Abaixo, detalhamos a ordem recomendada e as peças chave para construir essa camada do zero.

---

## 1. Criação do Projeto Base
O primeiro passo é inicializar o projeto web utilizando o padrão MVC (Model-View-Controller).

**Por onde começar:**
Você pode criar o projeto através do Visual Studio selecionando "ASP.NET Core Web App (Model-View-Controller)" ou pela linha de comando:
```bash
dotnet new mvc -n SenacFlix.UI --framework net9.0
```
Isso vai gerar a estrutura básica de pastas, que inclui `Controllers`, `Models`, `Views`, `wwwroot` e o arquivo `Program.cs`.

---

## 2. Configurações Iniciais (`Program.cs`)
Antes de criar as telas, o projeto precisa ser configurado para suportar tudo que o sistema utilizará: comunicação externa, segurança e injeção de dependências.

**O que construir/configurar:**
No arquivo `Program.cs`, você deve:
1. **Configurar Comunicação com a API:** Adicionar o serviço de `HttpClient` e configurar a URL base da API (lendo do `appsettings.json`).
2. **Configurar Autenticação por Cookies:** Para manter a sessão do usuário no navegador. No SenacFlix, o login bate na API (que devolve um JWT), e a UI guarda esse token dentro de um Cookie seguro.
3. **Injeção de Dependências:** Registrar as classes de serviço customizadas (`ApiCliente`, `ServicoUpload`) como *Scoped* para estarem disponíveis nos Controllers.
4. **Habilitar Mapeamento de "Areas":** Adicionar o suporte a áreas para separar o painel de administrador do painel comum (usando `app.MapControllerRoute` configurando `{area:exists}`).

---

## 3. Estruturação dos Serviços de Comunicação
Como a UI não fala com o banco, precisamos de classes focadas apenas em conversar com a API.

**O que construir (`Servicos/ApiCliente.cs`):**
1. Crie uma pasta chamada `Servicos` e dentro dela a classe `ApiCliente.cs`.
2. Essa classe recebe o `HttpClient` (configurado no `Program.cs`) via injeção de dependência.
3. Ela é responsável por criar métodos genéricos e específicos para fazer chamadas HTTP (GET, POST, PUT, DELETE) para os endpoints da API.
4. **Importante:** Essa classe também deve ser capaz de ler o *Cookie* (usando `IHttpContextAccessor`) para enviar o *Token JWT* no cabeçalho (*Authorization Bearer*) de todas as requisições autenticadas.

---

## 4. Infraestrutura e Uploads
Muitas entidades (como Filmes ou Perfil de Usuário) necessitam de upload de arquivos (ex: Capa do Filme).

**O que construir (`Infraestrutura/ServicoUpload.cs`):**
1. Crie uma pasta chamada `Infraestrutura`.
2. Crie uma classe que receba um `IFormFile` (que é como arquivos vêm nos formulários web) e se encarregue de salvá-lo fisicamente na pasta `wwwroot/uploads`.
3. Essa classe retorna o caminho relativo gerado (ex: `/uploads/filmes/foto123.jpg`), para que o Controller possa salvar esse caminho enviando-o para a API.

---

## 5. ViewModels e Models
Com a infraestrutura de comunicação pronta, preparamos os "pacotes de dados" que trafegarão entre as telas e a API.

**O que construir (`Models/` e `ViewModels/`):**
1. **ViewModels**: Classes usadas puramente para renderizar dados específicos na tela ou capturar dados de um formulário. Por exemplo, um `LoginViewModel` (com apenas Email e Senha) ou um `FilmeFormViewModel` (que pode incluir listas para preencher `<select>` do HTML).
2. **Models**: Representam as entidades de negócio (Filme, Categoria, Usuario), e refletem a estrutura JSON que a API devolve.

---

## 6. Criação da Área Administrativa (Areas)
Para manter o projeto organizado e separar a interface do administrador da interface do cliente, o SenacFlix.UI usa o conceito de *Areas*.

**O que construir (`Areas/Admin/`):**
1. Crie a pasta `Areas`, e dentro dela a subpasta `Admin`.
2. Dentro de `Admin`, replique a estrutura MVC: `Controllers`, `Models` e `Views`.
3. Controllers dessa área devem sempre ter a anotação `[Area("Admin")]`.
4. Construa aqui controladores como `CategoriasController`, `UsuariosController` e `FilmesController`, focados nos cadastros (CRUD) do sistema.

---

## 7. Controladores (Controllers)
Os Controllers são os maestros. Eles recebem as requisições da web, chamam os Serviços, e mandam a resposta visual (View) correta.

**O que construir (`Controllers/`):**
1. Comece pelo `ContaController` para criar os fluxos de **Login**, **Cadastro** e **Logout**. O Login chamará o `ApiCliente` enviando credenciais. Se a API responder sucesso com o token, o Controller cria o *Cookie* na máquina do usuário.
2. Crie controladores públicos como o `HomeController` (para a vitrine de filmes) ou o `PerfilController` (para a área do usuário).
3. **Fluxo Padrão de um Controller:**
   - Receber dados do formulário (`[HttpPost]`).
   - Se possuir imagem, chamar o `ServicoUpload`.
   - Passar os dados processados para o `ApiCliente` salvar na API.
   - Redirecionar o usuário para a listagem (Index) ou retornar uma View de sucesso.

---

## 8. Interface do Usuário (Views e wwwroot)
Por fim, construir e estilizar as telas de fato, consumindo os Models passados pelos Controllers.

**O que construir (`Views/` e `wwwroot/`):**
1. **Layout Padrão (`Views/Shared/_Layout.cshtml`):** O molde visual de toda a aplicação (Menus, rodapés, inclusão do CSS e JS principais).
2. **Estilos e Scripts (`wwwroot/`):** Inclua arquivos CSS customizados, bibliotecas de estilo (como Bootstrap), scripts JS e imagens fixas do sistema.
3. **Razor Views (`.cshtml`):** Para cada Action no Controller, crie um arquivo `.cshtml` correspondente (ex: `Index.cshtml`, `Create.cshtml`). 
4. Utilize a sintaxe do **Razor** (`@`) para misturar C# no meio do HTML (ex: fazer um `@foreach` em uma lista de filmes e gerar *cards* do Bootstrap para cada item).

---

### 🚀 Resumo do Fluxo de Trabalho Ideal
Se você fosse reconstruir isso hoje, a sequência seria:
1. `dotnet new mvc` (Criar o esqueleto).
2. Escrever o `ApiCliente` para "plugar" a UI na API.
3. Ajustar `Program.cs` para injeção e cookies.
4. Construir o fluxo de Autenticação (`ContaController` + Login View).
5. Configurar as `Areas` (Painel Administrativo) e testar segurança/login.
6. Desenvolver progressivamente cada módulo (Categorias, Filmes, Usuários):
   - Criar `ViewModel` -> Criar as rotas no `Controller` chamando API -> Desenhar a `.cshtml`.
