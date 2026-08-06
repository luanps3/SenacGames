# Manual de Implementação: CRUD de Usuários no SenacGames

**Objetivo:** Ensinar, passo a passo, como desenvolver o módulo completo de Usuários utilizando a arquitetura em camadas já existente da solução SenacGames, integrando com o ASP.NET Core Identity.

**Pré-requisitos:**
- Conhecimentos básicos de C# e Orientação a Objetos.
- Compreensão básica sobre requisições HTTP (GET, POST, PUT, DELETE).
- Familiaridade com o Visual Studio 2022.

**Tempo Estimado:** 3 a 4 horas.

**Competências Desenvolvidas:**
- Compreensão prática de Arquitetura em Camadas (Domain, Application, API, Desktop).
- Criação e uso de DTOs (Data Transfer Objects).
- Injeção de Dependência no ASP.NET Core.
- Criação de APIs RESTful usando Controllers.
- Integração e uso do ASP.NET Core Identity (UserManager, RoleManager).
- Consumo de API em aplicações Windows Forms (Desktop) utilizando HttpClient.
- Construção de interfaces ricas com Guna UI2 (DataGridView, Forms).

---

## CAPÍTULO 1 - A Arquitetura da Solução

O SenacGames adota a **Arquitetura em Camadas** (N-Tier Architecture), cujo objetivo é separar as responsabilidades do sistema. Cada projeto na solução tem uma função específica, e eles "conversam" entre si de maneira muito organizada.

- **`SenacGames.Domain`**: O "coração" do sistema. Contém as regras de negócio puras, entidades (classes que representam as tabelas do banco) e as interfaces dos repositórios.
- **`SenacGames.Infrastructure`**: A ponte com o mundo externo. É aqui que o Entity Framework Core "mora" e onde o acesso ao banco de dados acontece.
- **`SenacGames.Application`**: A camada "maestro". Ela recebe os pedidos da API, traduz os dados usando **DTOs**, aplica a lógica e delega as operações de banco para a camada de Infraestrutura. 
- **`SenacGames.API`**: A porta de entrada da web. Contém os **Controllers**, que recebem as requisições HTTP (via Front-end, Mobile ou Desktop) e repassam para a camada Application.
- **`SenacGames.Desktop` (UI)**: O cliente. É o aplicativo Windows Forms que o usuário final utiliza. Ele não se conecta ao banco de dados, mas sim consome a API através de serviços HTTP.

### Fluxo de Comunicação Textual
```text
[Desktop] (Tela do Usuário)
    ↓ (Chama um ApiService)
[API] (Recebe a requisição HTTP no Controller)
    ↓ (Chama um Service)
[Application] (Processa regras, mapeia DTOs)
    ↓ (Chama Repositório / Identity)
[Infrastructure] (Entity Framework Core)
    ↓
[Banco de Dados] (SQL Server)
```

---

## CAPÍTULO 2 - Analisando Módulos Existentes

Antes de criar um módulo novo, é fundamental estudar como os módulos já existentes (como **Games** e **Categorias**) foram construídos. Assim, nós mantemos o **padrão** do sistema. 

Se você observar o módulo de Categorias:
1. **Application/DTOs**: Existe um `CategoryDto` (para mostrar os dados) e um `CreateCategoryDto` (para criar).
2. **Application/Services**: O `CategoryService` contém os métodos `GetAllAsync`, `CreateAsync`, etc. Ele recebe os DTOs e retorna os resultados.
3. **API/Controllers**: O `CategoriesController` expõe rotas como `[HttpGet] /api/categories`.
4. **Desktop/Services**: O `CategoriasApiService` faz um `HttpClient.GetAsync` e desserializa o JSON.
5. **Desktop/UserControls**: O `CategoriasUserControl` usa um DataGridView para mostrar tudo em tela.

No CRUD de Usuários, faremos **exatamente** o mesmo fluxo!

---

## CAPÍTULO 3 - Planejamento do CRUD de Usuários

Vamos planejar nossa implementação. Precisamos criar os seguintes arquivos:

**Na Camada Application (Regra de Negócio):**
- `UsuarioDto.cs`: Para transferir os dados sem expor as senhas diretamente.
- `IUsuariosService.cs`: O contrato contendo o que nosso serviço sabe fazer.
- `UsuariosService.cs`: A implementação real, que vai usar o Identity para gravar os usuários.

**Na Camada API (Exposição REST):**
- `UsuariosController.cs`: Os endpoints REST que o Desktop vai consumir.

**Na Camada Desktop (Tela do Usuário):**
- `UsuarioDtos.cs`: Espelho dos DTOs da API, para desserializar o JSON.
- `UsuariosApiService.cs`: Para fazer o *fetch* (GET, POST) lá na API.
- `UsuarioFormDialog.cs`: A janelinha pop-up onde o admin vai digitar o nome, email e senha.
- `UsuariosUserControl.cs`: A tela principal com a grade (grid) de usuários.

---

## CAPÍTULO 4 - Implementação Passo a Passo

### 1. DTOs (Data Transfer Objects)
**Objetivo:** Criar as classes que representam os dados transitando entre a API e as demais camadas.
**Por que?** Evita o envio de entidades pesadas ou dados sensíveis, garantindo segurança e melhor performance.

Crie o arquivo `UsuarioDto.cs` na pasta `DTOs` no projeto **`SenacGames.Application`**:

```csharp
namespace SenacGames.Application.DTOs
{
    // DTO usado para listar (repare que não enviamos a senha para a tela!)
    public class UsuarioDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }

    // DTO usado APENAS quando formos criar um usuário novo
    public class CreateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfirmarSenha { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }

    // DTO para atualizar (senha é opcional)
    public class UpdateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Senha { get; set; }
        public string? ConfirmarSenha { get; set; }
        public string Perfil { get; set; } = string.Empty;
    }
}
```

### 2. Interface do Serviço (`IUsuariosService`)
Na pasta `Interfaces` de `SenacGames.Application`, crie o contrato:

```csharp
using SenacGames.Application.DTOs;

namespace SenacGames.Application.Interfaces
{
    public interface IUsuariosService
    {
        Task<IEnumerable<UsuarioDto>> GetAllAsync();
        Task<UsuarioDto?> GetByIdAsync(string id);
        Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> CreateAsync(CreateUsuarioDto dto);
        Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> UpdateAsync(string id, UpdateUsuarioDto dto);
        Task<(bool Success, string ErrorMessage)> DeleteAsync(string id);
        Task<IEnumerable<string>> GetPerfisAsync();
    }
}
```

### 3. Implementação do Serviço (`UsuariosService`) com Identity
**Objetivo:** Implementar as lógicas da interface e gravar no banco usando Identity.
**Por que Identity?** O ASP.NET Core Identity já fornece uma infraestrutura robusta para senhas criptografadas (hash), roles (perfis) e autenticação. Não precisamos reinventar a roda criando uma tabela manual de usuários. Usaremos o `UserManager` e o `RoleManager`.

Na pasta `Services`, crie `UsuariosService.cs`:

```csharp
using Microsoft.AspNetCore.Identity;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.Application.Services
{
    public class UsuariosService : IUsuariosService
    {
        // O ASP.NET Injeta (Dependency Injection) essas classes automaticamente pra nós!
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuariosService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var users = _userManager.Users.ToList();
            var result = new List<UsuarioDto>();

            // Iteramos sobre os usuários do banco e transformamos em UsuarioDto
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                result.Add(new UsuarioDto
                {
                    Id = user.Id,
                    Nome = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    Perfil = roles.FirstOrDefault() ?? "Usuario"
                });
            }
            return result;
        }

        public async Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> CreateAsync(CreateUsuarioDto dto)
        {
            // Validação simples
            if (dto.Senha != dto.ConfirmarSenha)
                return (false, null, "As senhas não coincidem.");

            // Criar o modelo base do Identity
            var user = new IdentityUser { UserName = dto.Nome, Email = dto.Email };
            
            // Aqui a mágica do Hash de senha acontece
            var result = await _userManager.CreateAsync(user, dto.Senha);

            if (!result.Succeeded) return (false, null, "Erro ao criar usuário.");

            // Adiciona o perfil (ex: "Admin" ou "Usuario")
            await _userManager.AddToRoleAsync(user, dto.Perfil);

            var createdUser = new UsuarioDto { Id = user.Id, Nome = user.UserName, Email = user.Email, Perfil = dto.Perfil };
            return (true, createdUser, string.Empty);
        }
        
        // ... (Para encurtar, implemente Update, Delete e GetById de maneira similar)
    }
}
```

> **Dica:** Note que usamos Tuplas `(bool Success, UsuarioDto? Usuario, string ErrorMessage)` como retorno. É uma prática muito boa do C# para retornar status da operação sem lançar *Exceptions* caríssimas a todo instante.

### 4. Controller (`UsuariosController`) na API
Crie `UsuariosController.cs` dentro da pasta `Controllers` no **`SenacGames.API`**:

```csharp
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.API.Controllers
{
    [ApiController]           // Define que esta classe responde a requisições HTTP (JSON)
    [Route("api/[controller]")] // A rota será: localhost:porta/api/usuarios
    [Authorize]               // Exige que o cliente esteja logado com um token/cookie
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet] // GET /api/usuarios
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios); // Retorna HTTP 200 com a lista em JSON
        }

        [HttpPost] // POST /api/usuarios
        public async Task<ActionResult<UsuarioDto>> Create([FromBody] CreateUsuarioDto dto)
        {
            var (success, usuario, error) = await _usuariosService.CreateAsync(dto);
            if (!success) return BadRequest(new { message = error }); // HTTP 400
            
            return Ok(usuario); // HTTP 200
        }
    }
}
```

> **Atenção (Injeção de Dependência):** Após criar a interface e o serviço, você DEVE ir no arquivo `Program.cs` da API e avisar ao ASP.NET Core que eles existem:
> `builder.Services.AddScoped<IUsuariosService, UsuariosService>();`

### 5. Testes da API (Swagger)
Rode a API apertando `F5`. O **Swagger** abrirá. O Swagger é uma documentação viva da sua API.
Como colocamos `[Authorize]`, primeiro você precisa usar o endpoint `POST /api/auth/login` para autenticar. Em seguida, procure a seção de `Usuarios`, clique em **Try it out** no método `GET`, e receba um JSON contendo seus usuários!

---

### 6. Consumindo a API no Desktop (`UsuariosApiService`)
No projeto **`SenacGames.Desktop`**, pasta `Services`, crie o serviço que converte os botões do formulário em chamadas de rede.

```csharp
using SenacGames.Desktop.DTOs;
using SenacGames.Desktop.Helpers;

namespace SenacGames.Desktop.Services
{
    public class UsuariosApiService
    {
        // O HttpClientHelper faz o trabalho pesado de converter classes para JSON
        private readonly HttpClientHelper _http;

        public UsuariosApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        public async Task<List<UsuarioResponseDto>> GetAllAsync()
        {
            try
            {
                // Faz a chamada na URL e transforma o JSON retornado numa List C#
                var (success, usuarios, errorMessage) = await _http.GetAsync<List<UsuarioResponseDto>>("/api/usuarios");
                return usuarios ?? new List<UsuarioResponseDto>();
            }
            catch
            {
                return new List<UsuarioResponseDto>();
            }
        }
    }
}
```

### 7. Interface Gráfica (`UsuariosUserControl`)
A interface usa o **Windows Forms** com a biblioteca moderna Guna UI. 
- Use um `DataGridView` para mostrar a listagem.
- Crie botões para: **Novo**, **Editar**, **Excluir** e **Atualizar**.

No evento `Load` do seu UserControl, você chama o banco de dados:

```csharp
private async void UsuariosUserControl_Load(object sender, EventArgs e)
{
    if (DesignMode) return;
    _usuariosService = new UsuariosApiService();
    
    // Oculta os botões se não for Admin
    bool isAdmin = SessionManager.Instance.IsAdmin;
    btnNovo.Visible = isAdmin;
    btnEditar.Visible = isAdmin;
    
    await CarregarDadosAsync();
}

private async Task CarregarDadosAsync()
{
    var usuarios = await _usuariosService.GetAllAsync();
    
    gridUsuarios.Rows.Clear();
    foreach(var u in usuarios)
    {
        // Adiciona as colunas no GridView
        gridUsuarios.Rows.Add(u.Id, u.Nome, u.Email, u.Perfil);
    }
}
```

### 8. Validações
Sempre aplique regras de validação! Seja no frontend (para feedback rápido do usuário) ou no backend (por segurança).
- **Frontend (No clique de Salvar do Formulário Desktop):** 
`if (txtSenha.Text != txtConfirmarSenha.Text) MessageBox.Show("As senhas não coincidem!");`
- **Backend (No Application Service):**
Também verifique senhas idênticas, obrigatoriedade de campos e evite emails duplicados com `await _userManager.FindByEmailAsync(dto.Email);`

---

## CAPÍTULO 5 - Debugging e Resolução de Problemas

Se algo não funcionar, a melhor ferramenta é o **Breakpoint** (Bolinha vermelha no canto da linha):
1. **Problemas na Tela:** Coloque o breakpoint no botão Salvar do Desktop. Pressione `F10` (Step Over) para ler linha por linha. Verifique se as variáveis de texto estão capturando as digitações corretamente.
2. **Problemas na API:** Coloque o breakpoint no `UsuariosController`. Se a execução sequer chegar lá, significa que sua rota está errada ou que o token de autenticação falhou (você vai tomar um erro 401 Unauthorized ou 404 Not Found no desktop).
3. **Problemas de Injeção de Dependência:** Ocorreu um erro 500 no carregamento dizendo que a interface não pôde ser resolvida? Verifique se você não se esqueceu do `AddScoped` no `Program.cs`.

---

## EXERCÍCIOS DE FIXAÇÃO

**Exercício 1:** Modifique a API e o Desktop para que o campo "Email" seja listado junto do nome no DataGridView do form.
**Exercício 2:** Crie um filtro na interface Desktop onde você pode digitar o nome e a tela vai esconder usuários que não contiverem a letra pesquisada (Pesquisa Local via LINQ).
**Exercício 3:** Modifique a criação para não deixar cadastrar nomes em branco.

---

## DESAFIOS EXTRAS (Para os Avançados)

1. **Alterar Senha do Usuário logado:** Crie um botão "Meu Perfil" onde o usuário consegue alterar sua própria senha, mas precise inserir a "Senha Antiga" antes (usando `ChangePasswordAsync` do Identity).
2. **Ativar / Inativar Usuário:** Adicione um atributo booleano (verdadeiro/falso) no Banco de Dados para que o admin possa bloquear usuários temporariamente ao invés de apagá-los completamente (Exclusão Lógica).

---

## CHECKLIST DE SUCESSO

Marque cada item quando finalizar:

- [ ] DTOs criados e configurados.
- [ ] Interface `IUsuariosService` estruturada.
- [ ] Classe `UsuariosService` implementada (CRUD) usando ASP.NET Identity.
- [ ] Interface injetada no container (Program.cs).
- [ ] `UsuariosController` construído e protegido.
- [ ] API testada via Swagger com sucesso.
- [ ] `UsuariosApiService` no Desktop enviando requisições REST corretamente.
- [ ] Janela de formulário `UsuarioFormDialog` responsiva e salvando dados.
- [ ] Grid de visualização (`UsuariosUserControl`) renderizando os usuários no painel principal.

---
**Fim do Manual. Boa programação!**
