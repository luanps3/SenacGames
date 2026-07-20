# ROADMAP — SenacGames

> Guia passo a passo para criar a solução SenacGames do zero.
> Voltado para alunos iniciantes em ASP.NET Core MVC, arquitetura em camadas e Windows Forms.

---

## Índice

1. [Entendendo a Arquitetura](#1-entendendo-a-arquitetura)
2. [Criação da Solution](#2-criação-da-solution)
3. [Criação das Camadas](#3-criação-das-camadas)
4. [Referências entre Projetos](#4-referências-entre-projetos)
5. [Instalação dos Pacotes NuGet](#5-instalação-dos-pacotes-nuget)
6. [Camada Domain](#6-camada-domain)
7. [Camada Application](#7-camada-application)
8. [Camada Infrastructure](#8-camada-infrastructure)
9. [Entity Framework — Migrations](#9-entity-framework--migrations)
10. [Identity — Autenticação](#10-identity--autenticação)
11. [Projeto API](#11-projeto-api)
12. [Projeto UI (MVC)](#12-projeto-ui-mvc)
13. [Executando a Aplicação](#13-executando-a-aplicação)
14. [Construindo o SenacGames.Desktop](#14-construindo-o-senacgamesdesktop)

---

## 1. Entendendo a Arquitetura

### Por que usar camadas?

A arquitetura em camadas separa o código em projetos com responsabilidades específicas. Isso traz benefícios como:

- **Organização**: cada camada tem uma responsabilidade clara
- **Manutenção**: alterações em uma camada não afetam as outras
- **Testabilidade**: facilita a criação de testes unitários
- **Reutilização**: a mesma lógica pode ser usada por MVC e API

### Estrutura do SenacGames

```
┌──────────────┐   ┌──────────────┐   ┌──────────────────┐
│ SenacGames   │   │ SenacGames   │   │ SenacGames       │
│    .API      │   │    .UI       │   │    .Desktop      │
│ (API REST)   │   │   (MVC)      │   │ (Windows Forms)  │
└──────┬───────┘   └──────┬───────┘   └────────┬─────────┘
       │                  │                    │ HTTP
       └──────────────────┘                    │
                │                              │
       ┌────────▼──────────────────────────────┘
       │
  ┌────▼────────────┐
  │   SenacGames    │
  │  .Application   │
  │ (Serviços/DTOs) │
  └────────┬────────┘
           │
  ┌────────▼────────┐
  │   SenacGames    │
  │    .Domain      │
  │  (Entidades)    │
  └─────────────────┘
           ▲
  ┌────────┴────────┐
  │   SenacGames    │
  │ .Infrastructure │
  │  (EF Core/BD)   │
  └─────────────────┘
```

> **Importante**: O Desktop se comunica **apenas** com a API via HTTP.
> Ele não conhece nem referencia as camadas internas da solução.

### Papel de cada camada

| Camada | Tipo de Projeto | Responsabilidade |
|--------|-----------------|-----------------|
| **Domain** | Class Library | Entidades e Interfaces |
| **Application** | Class Library | Services, DTOs, ViewModels |
| **Infrastructure** | Class Library | EF Core, Repositories, Identity |
| **API** | ASP.NET Core Web API | Endpoints REST, Swagger |
| **UI** | ASP.NET Core MVC | Cliente HTTP da API (Páginas Web) |
| **Desktop** | Windows Forms | Cliente HTTP da API (Admin Desktop) |

### Fluxo de uma requisição (Web e Desktop)

```
Usuário → Controller/Form → HttpService → HttpClient → API → Application Service → Repository → BD
```

> **Importante:** Tanto a UI (Web) quanto o Desktop **nunca** tocam nas camadas internas. Ambos são clientes que falam com a API via HTTP.

---

## 2. Criação da Solution

### O que é uma Solution?

Uma **Solution** (.sln) é um arquivo que agrupa vários projetos do .NET. No Visual Studio, é como uma "pasta" que contém todos os seus projetos.

### Via Visual Studio

1. Abra o Visual Studio
2. Clique em **"Criar um novo projeto"**
3. Procure por **"Solução em Branco"**
4. Nome: `SenacGames`
5. Local: escolha uma pasta de sua preferência
6. Clique em **Criar**

### Via terminal (PowerShell ou CMD)

#### Opção 2 — PowerShell

```powershell
# PowerShell:
# Navegue até a pasta onde deseja criar o projeto
cd C:\Users\SeuUsuario\source\repos

# Cria a pasta do projeto
mkdir SenacGames
cd SenacGames

# Cria a Solution
dotnet new sln -n SenacGames
```

#### Opção 3 — Prompt de Comando (CMD)

```cmd
REM CMD:
cd C:\Users\SeuUsuario\source\repos
mkdir SenacGames
cd SenacGames
dotnet new sln -n SenacGames
```

---

## 3. Criação das Camadas

Agora vamos criar cada projeto da solução.

### 3.1 — SenacGames.Domain (Class Library)

**Função**: Contém as entidades e interfaces do sistema. É o "coração" da aplicação.
**Tipo**: Biblioteca de Classes (Class Library)

#### PowerShell

```powershell
# PowerShell:
dotnet new classlib -n SenacGames.Domain -o SenacGames.Domain --framework net8.0
dotnet sln add SenacGames.Domain/SenacGames.Domain.csproj
```

#### CMD

```cmd
REM CMD:
dotnet new classlib -n SenacGames.Domain -o SenacGames.Domain --framework net8.0
dotnet sln add SenacGames.Domain\SenacGames.Domain.csproj
```

### 3.2 — SenacGames.Application (Class Library)

**Função**: Contém a lógica de aplicação — Services, DTOs e ViewModels.

```powershell
# PowerShell:
dotnet new classlib -n SenacGames.Application -o SenacGames.Application --framework net8.0
dotnet sln add SenacGames.Application/SenacGames.Application.csproj
```

### 3.3 — SenacGames.Infrastructure (Class Library)

**Função**: Contém o acesso a dados — Entity Framework Core, Repositories, Identity.

```powershell
# PowerShell:
dotnet new classlib -n SenacGames.Infrastructure -o SenacGames.Infrastructure --framework net8.0
dotnet sln add SenacGames.Infrastructure/SenacGames.Infrastructure.csproj
```

### 3.4 — SenacGames.API (Web API)

**Função**: Expõe endpoints REST com Swagger.

```powershell
# PowerShell:
dotnet new webapi -n SenacGames.API -o SenacGames.API --framework net8.0
dotnet sln add SenacGames.API/SenacGames.API.csproj
```

### 3.5 — SenacGames.UI (MVC)

**Função**: Aplicação web com Controllers, Views Razor e Bootstrap.

```powershell
# PowerShell:
dotnet new mvc -n SenacGames.UI -o SenacGames.UI --framework net8.0
dotnet sln add SenacGames.UI/SenacGames.UI.csproj
```

---

## 4. Referências entre Projetos

### Por que adicionar referências?

Cada camada precisa "enxergar" as camadas abaixo dela. Sem as referências, um projeto não consegue usar as classes de outro projeto.

### Regras de referência

```
Application → Domain
Infrastructure → Domain, Application
API → Application, Infrastructure
UI → Application, Infrastructure
```

#### PowerShell

```powershell
# PowerShell:
# Application depende do Domain
dotnet add SenacGames.Application reference SenacGames.Domain

# Infrastructure depende do Domain e Application
dotnet add SenacGames.Infrastructure reference SenacGames.Domain
dotnet add SenacGames.Infrastructure reference SenacGames.Application

# API depende de Application e Infrastructure
dotnet add SenacGames.API reference SenacGames.Application
dotnet add SenacGames.API reference SenacGames.Infrastructure

# UI depende de Application e Infrastructure
dotnet add SenacGames.UI reference SenacGames.Application
dotnet add SenacGames.UI reference SenacGames.Infrastructure
```

#### Via Visual Studio

1. Clique com o botão direito no projeto → **Adicionar** → **Referência de Projeto**
2. Marque os projetos necessários
3. Clique em **OK**

---

## 5. Instalação dos Pacotes NuGet

### O que são pacotes NuGet?

NuGet é o gerenciador de pacotes do .NET. Os pacotes são bibliotecas prontas que adicionam funcionalidades ao projeto.

### Pacotes necessários

#### SenacGames.Infrastructure

#### Opção 1 — Console do Gerenciador de Pacotes (Package Manager Console — Visual Studio)

Acesse: **Ferramentas → Gerenciador de Pacotes NuGet → Console do Gerenciador de Pacotes**

> ** IMPORTANTE**: No dropdown "Projeto padrão", selecione **SenacGames.Infrastructure**.

```powershell
# Console do Gerenciador de Pacotes:
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.11
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.11
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.11
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 8.0.11
```

#### Opção 2 — PowerShell

```powershell
# PowerShell:
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.11
```

#### Opção 3 — Prompt de Comando (CMD)

```cmd
REM CMD:
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
dotnet add SenacGames.Infrastructure package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.11
```

#### SenacGames.API

```powershell
# PowerShell:
dotnet add SenacGames.API package Microsoft.EntityFrameworkCore.Design --version 8.0.11
dotnet add SenacGames.API package Swashbuckle.AspNetCore --version 6.5.0
```

#### SenacGames.UI

```powershell
# PowerShell:
dotnet add SenacGames.UI package Microsoft.EntityFrameworkCore.Design --version 8.0.11
```

### Instalar dotnet-ef (ferramenta global)

```powershell
# PowerShell — Instala a ferramenta globalmente:
dotnet tool install --global dotnet-ef --version 8.0.11
```

> ** Nota**: O `dotnet-ef` é necessário para executar os comandos `dotnet ef migrations` e `dotnet ef database update` via terminal.

---

## 6. Camada Domain

### Estrutura de pastas

```
SenacGames.Domain/
├── Entities/
│  ├── Game.cs
│  └── Category.cs
└── Interfaces/
  ├── IGameRepository.cs
  └── ICategoryRepository.cs
```

### 6.1 — Entidade Game

Crie a pasta `Entities` dentro de `SenacGames.Domain` e adicione o arquivo `Game.cs`:

- **Id**: Chave primária (gerada automaticamente)
- **Title**: Título do game
- **Description**: Descrição do game
- **ReleaseYear**: Ano de lançamento
- **CoverImageUrl**: URL da imagem de capa
- **CategoryId**: Chave estrangeira para Category (relacionamento N:1)
- **IsFeatured**: Se o game está em destaque
- **CreatedAt**: Data de criação
- **Category**: Propriedade de navegação

### 6.2 — Entidade Category

- **Id**: Chave primária
- **Name**: Nome da categoria
- **Games**: Coleção de games (relação 1:N)

### 6.3 — Interfaces de Repositório

As interfaces definem O QUE os repositórios devem fazer, sem definir COMO.

---

## 7. Camada Application

### Estrutura de pastas

```
SenacGames.Application/
├── DTOs/
│  ├── GameDto.cs
│  ├── CategoryDto.cs
│  └── AuthDto.cs
├── Interfaces/
│  ├── IGameService.cs
│  └── ICategoryService.cs
├── Services/
│  ├── GameService.cs
│  └── CategoryService.cs
└── ViewModels/
  └── ViewModels.cs
```

### 7.1 — DTOs (Data Transfer Objects)

DTOs são objetos usados para transferir dados entre camadas. Evitam expor a entidade diretamente.

### 7.2 — Services

Os serviços orquestram as operações:
1. Recebem DTOs do Controller
2. Convertem para Entidades
3. Chamam o Repositório
4. Convertem o resultado para DTO/ViewModel
5. Retornam para o Controller

---

## 8. Camada Infrastructure

### Estrutura de pastas

```
SenacGames.Infrastructure/
├── Context/
│  └── SenacGamesDbContext.cs
├── Configurations/
│  ├── GameConfiguration.cs
│  └── CategoryConfiguration.cs
├── Repositories/
│  ├── GameRepository.cs
│  └── CategoryRepository.cs
├── Identity/
│  └── SeedData.cs
└── Migrations/
  └── (geradas automaticamente)
```

### 8.1 — DbContext

O `SenacGamesDbContext` herda de `IdentityDbContext` para incluir as tabelas do Identity (usuários, roles, etc.).

### 8.2 — Configurações Fluent API

Usamos `IEntityTypeConfiguration<T>` para definir regras do banco de dados:
- Tamanhos máximos de campos
- Campos obrigatórios
- Relacionamentos entre tabelas

### 8.3 — Repositórios

Os repositórios implementam as interfaces do Domain usando Entity Framework Core.

### 8.4 — Seed Data

Dados iniciais que são inseridos na primeira execução:
- 8 categorias (Ação, Aventura, RPG, etc.)
- 8 games de exemplo
- Usuário admin (admin@senacgames.com / Admin@123)

---

## 9. Entity Framework — Migrations

### O que são Migrations?

Migrations são o mecanismo do Entity Framework para criar e atualizar o banco de dados. Cada migration representa uma alteração no esquema do banco.

### Informações importantes

- **Projeto que contém o DbContext**: `SenacGames.Infrastructure`
- **Projeto startup**: `SenacGames.API` (ou `SenacGames.UI`)
- **Banco de dados**: SQL Server LocalDB

### Criar a migration inicial

#### Opção 1 — Console do Gerenciador de Pacotes (Package Manager Console — Visual Studio)

O Package Manager Console usa comandos do Entity Framework **sem** o prefixo `dotnet`.

Acesse: **Ferramentas → Gerenciador de Pacotes NuGet → Console do Gerenciador de Pacotes**

> ** IMPORTANTE**: No dropdown "Projeto padrão", selecione `SenacGames.Infrastructure`.
> Certifique-se de que o projeto de inicialização (startup) é `SenacGames.API`.

```powershell
# Console do Gerenciador de Pacotes:
Add-Migration Inicial -Project SenacGames.Infrastructure -StartupProject SenacGames.API
```

```powershell
# Console do Gerenciador de Pacotes:
Update-Database -Project SenacGames.Infrastructure -StartupProject SenacGames.API
```

---

#### Opção 2 — PowerShell

O PowerShell utiliza a CLI do .NET com comandos `dotnet ef`.

Primeiro, instale o `dotnet-ef` globalmente (se ainda não fez):

```powershell
# PowerShell — Instalar dotnet-ef:
dotnet tool install --global dotnet-ef --version 8.0.11
```

Agora execute os comandos de migration:

```powershell
# PowerShell — Criar a migration:
dotnet ef migrations add Inicial --project SenacGames.Infrastructure --startup-project SenacGames.API
```

```powershell
# PowerShell — Aplicar a migration no banco:
dotnet ef database update --project SenacGames.Infrastructure --startup-project SenacGames.API
```

---

#### Opção 3 — Prompt de Comando (CMD)

O CMD utiliza os mesmos comandos `dotnet ef` do PowerShell.

```cmd
REM CMD — Criar a migration:
dotnet ef migrations add Inicial --project SenacGames.Infrastructure --startup-project SenacGames.API
```

```cmd
REM CMD — Aplicar a migration:
dotnet ef database update --project SenacGames.Infrastructure --startup-project SenacGames.API
```

---

## 10. Identity — Autenticação

### O que é ASP.NET Core Identity?

O Identity é o sistema de autenticação e autorização do ASP.NET Core. Ele gerencia:
- Criação de usuários
- Login e Logout
- Hash de senhas
- Roles (papéis de acesso)
- Cookies de autenticação

### Tabelas criadas pelo Identity

O Identity cria automaticamente as seguintes tabelas no banco:
- `AspNetUsers` — Usuários
- `AspNetRoles` — Papéis (Admin, User, etc.)
- `AspNetUserRoles` — Relacionamento Usuário ↔ Role
- `AspNetUserClaims` — Claims do usuário
- `AspNetRoleClaims` — Claims da role

### Configuração no Program.cs

```csharp
// Registra o Identity com Entity Framework
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
  options.Password.RequireDigit = true;
  options.Password.RequireLowercase = true;
  options.Password.RequireUppercase = true;
  options.Password.RequireNonAlphanumeric = true;
  options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<SenacGamesDbContext>()
.AddDefaultTokenProviders();
```

### Proteção de rotas com [Authorize]

```csharp
// Qualquer usuário autenticado pode acessar
[Authorize]
public class ProfileController : Controller { }

// Apenas admin pode acessar
[Authorize(Roles = "Admin")]
public class AdminController : Controller { }
```

---

## 11. Projeto API

### Estrutura

```
SenacGames.API/
├── Controllers/
│  ├── GamesController.cs
│  ├── CategoriesController.cs
│  └── AuthController.cs
├── Program.cs
└── appsettings.json
```

### Endpoints REST

| Método | Endpoint | Descrição | Auth |
|--------|----------|-----------|------|
| GET | `/api/games` | Lista games | Não |
| GET | `/api/games/{id}` | Busca game | Não |
| POST | `/api/games` | Cria game | Sim (Admin) |
| PUT | `/api/games/{id}` | Atualiza | Sim (Admin) |
| DELETE | `/api/games/{id}` | Remove | Sim (Admin) |
| POST | `/api/auth/login` | Login | Não |
| POST | `/api/auth/register` | Register | Não |
| GET | `/api/auth/me` | Dados usuário | Sim |

### Swagger

Acesse `https://localhost:PORTA/swagger` para ver a documentação automática e testar os endpoints.

---

## 12. Projeto UI (MVC)

### O que é MVC?

- **Model**: Os dados (ViewModels/DTOs)
- **View**: A interface (Razor .cshtml)
- **Controller**: A lógica (recebe requisição → processa → retorna view)

### Estrutura

```
SenacGames.UI/
├── Controllers/
│  ├── HomeController.cs    → Página inicial
│  ├── GamesController.cs   → Catálogo público
│  ├── AccountController.cs  → Login/Register
│  └── AdminController.cs   → Dashboard + CRUD
├── Views/
│  ├── Shared/
│  │  ├── _Layout.cshtml   → Layout público (navbar)
│  │  └── _AdminLayout.cshtml → Layout admin (sidebar)
│  ├── Home/Index.cshtml    → Home page
│  ├── Games/
│  │  ├── Index.cshtml     → Catálogo
│  │  └── Details.cshtml    → Detalhes do game
│  ├── Account/
│  │  ├── Login.cshtml
│  │  ├── Register.cshtml
│  │  └── AccessDenied.cshtml
│  └── Admin/
│    ├── Index.cshtml     → Dashboard
│    ├── Games.cshtml     → Lista de games
│    ├── CreateGame.cshtml  → Cadastrar game
│    ├── EditGame.cshtml   → Editar game
│    ├── DeleteGame.cshtml  → Confirmar exclusão
│    ├── Categories.cshtml  → Lista de categorias
│    ├── CreateCategory.cshtml
│    ├── EditCategory.cshtml
│    └── DeleteCategory.cshtml
└── wwwroot/
  └── css/site.css       → Design customizado
```

### Layouts

- **_Layout.cshtml**: Layout público com navbar azul Senac e footer
- **_AdminLayout.cshtml**: Layout admin com sidebar fixa à esquerda

### Rotas MVC

```
/             → HomeController.Index()
/Games           → GamesController.Index()
/Games/Details/5      → GamesController.Details(5)
/Account/Login       → AccountController.Login()
/Account/Register     → AccountController.Register()
/Admin           → AdminController.Index() (Dashboard)
/Admin/Games        → AdminController.Games()
/Admin/CreateGame     → AdminController.CreateGame()
/Admin/EditGame/5     → AdminController.EditGame(5)
```

---

## 13. Executando a Aplicação

### Compilar a solução

```powershell
# PowerShell:
dotnet build
```

### Executar a API

```powershell
# PowerShell:
dotnet run --project SenacGames.API
```

> O Swagger estará disponível em: `https://localhost:PORTA/swagger`

### Executar a UI (MVC)

```powershell
# PowerShell:
dotnet run --project SenacGames.UI
```

> A aplicação web estará disponível em: `https://localhost:PORTA`

### Login como Admin

1. Acesse `/Account/Login`
2. Email: `admin@senacgames.com`
3. Senha: `Admin@123`
4. Após o login, acesse `/Admin` para o dashboard

---

## Resumo Final (Seções 1–13)

Ao concluir os passos 1 a 13 deste roadmap, você terá:

- Uma solution com 5 projetos em camadas
- Entidades Game e Category com EF Core
- Repositórios e Services organizados
- API REST com Swagger
- MVC com Views Razor e Bootstrap 5
- Autenticação com Identity (Login, Register, Roles)
- Dashboard administrativo
- CRUD completo de Games e Categorias
- Seed Data com dados iniciais
- Design moderno baseado no protótipo Stitch

Continue para a **seção 14** para adicionar o cliente Desktop Windows Forms!

---

## 14. Construindo o SenacGames.Desktop

### Objetivo desta camada

O `SenacGames.Desktop` é uma aplicação **Windows Forms** que funciona como
**cliente administrativo** do sistema, consumindo exclusivamente a API já existente.

**Por que adicionar um Desktop?**
- Demonstra que a mesma API pode ser consumida por múltiplos clientes
- Ensina consumo de API REST com `HttpClient` em aplicações desktop
- Apresenta o padrão de **Cookie Authentication** em clientes não-web
- Mostra o uso do Guna.UI2 para interfaces modernas no Windows Forms

**Regras obrigatórias:**
- ❌ NÃO acessar banco de dados diretamente
- ❌ NÃO referenciar `SenacGames.Infrastructure`
- ❌ NÃO referenciar `SenacGames.Domain`
- ❌ NÃO referenciar `SenacGames.Application`
- ✅ TODA comunicação ocorre via endpoints da API

---

### 14.1 — Por que Windows Forms?

O Windows Forms é o framework de interface desktop mais didático do .NET:
- Componentes visuais arrastáveis (Designer)
- Curva de aprendizado baixa para iniciantes
- Suporte nativo ao .NET 8
- Base para entender padrões de interface (eventos, controles, layouts)

### 14.2 — Por que Guna.UI2?

O Guna.UI2.WinForms é uma biblioteca de componentes visuais para Windows Forms que oferece:
- Botões animados com hover suave
- Painéis com bordas arredondadas e sombras
- Campos de texto com placeholder e estilos modernos
- Visual próximo ao Material Design / Fluent Design
- Elimina a aparência "antiga" do Windows Forms padrão

---

### 14.3 — Criação do Projeto Desktop

#### Via Visual Studio

1. Clique com o botão direito na Solution → **Adicionar** → **Novo Projeto**
2. Procure por **"Aplicativo do Windows Forms"**
3. Nome: `SenacGames.Desktop`
4. Framework: **.NET 8.0**
5. Clique em **Criar**

#### Opção 2 — PowerShell

```powershell
# PowerShell — cria o projeto e adiciona à solution:
dotnet new winforms -n SenacGames.Desktop -o SenacGames.Desktop --framework net8.0
dotnet sln add SenacGames.Desktop/SenacGames.Desktop.csproj
```

#### Opção 3 — Prompt de Comando (CMD)

```cmd
REM CMD:
dotnet new winforms -n SenacGames.Desktop -o SenacGames.Desktop --framework net8.0
dotnet sln add SenacGames.Desktop\SenacGames.Desktop.csproj
```

> **Nota**: O template gera automaticamente `net8.0-windows` com `<UseWindowsForms>true</UseWindowsForms>`.

---

### 14.4 — Instalação das Dependências

#### Guna.UI2.WinForms

##### Opção 1 — Console do Gerenciador de Pacotes (Package Manager Console)

Acesse: **Ferramentas → Gerenciador de Pacotes NuGet → Console do Gerenciador de Pacotes**

> **IMPORTANTE**: No dropdown "Projeto padrão", selecione **SenacGames.Desktop**.

```powershell
Install-Package Guna.UI2.WinForms
```

##### Opção 2 — PowerShell

```powershell
dotnet add SenacGames.Desktop package Guna.UI2.WinForms
```

##### Opção 3 — Prompt de Comando (CMD)

```cmd
dotnet add SenacGames.Desktop package Guna.UI2.WinForms
```

#### HttpClient (nativo do .NET)

O `HttpClient` já faz parte do .NET — não precisa instalar pacote adicional.
Basta usar o namespace `System.Net.Http`.

---

### 14.5 — Estrutura de Pastas Recomendada

```
SenacGames.Desktop/
├── Forms/
│   ├── LoginForm.cs           → Tela de login
│   ├── MainForm.cs            → Shell: sidebar + painel de conteúdo
│   ├── GameFormDialog.cs      → Dialog: criar/editar game
│   └── UsuarioFormDialog.cs   → Dialog: criar usuário
│
├── UserControls/
│   ├── DashboardUserControl.cs   → Métricas + últimos games
│   ├── GamesUserControl.cs       → CRUD de games
│   ├── CategoriasUserControl.cs  → CRUD de categorias
│   ├── UsuariosUserControl.cs    → Gerenciamento de usuários
│   └── PerfilUserControl.cs      → Perfil do usuário logado
│
├── Services/
│   ├── AuthApiService.cs         → /api/auth/*
│   ├── GamesApiService.cs        → /api/games/*
│   ├── CategoriasApiService.cs   → /api/categories/*
│   └── UsuariosApiService.cs     → /api/users/*
│
├── DTOs/
│   ├── AuthDtos.cs       → LoginRequestDto, UserResponseDto
│   ├── GameDtos.cs       → GameResponseDto, CreateGameDto, UpdateGameDto
│   ├── CategoriaDtos.cs  → CategoriaResponseDto, CreateCategoriaDto
│   └── UsuarioDtos.cs    → UsuarioResponseDto, CreateUsuarioDto
│
├── Helpers/
│   ├── HttpClientHelper.cs  → HttpClient Singleton + CookieContainer
│   ├── SessionManager.cs    → Singleton: dados do usuário logado
│   └── AppConfig.cs         → Leitura do appsettings.json
│
├── Themes/
│   └── SenacTheme.cs        → Design system: cores, fontes, dimensões
│
├── appsettings.json           → URL da API e configurações
├── Program.cs                 → Ponto de entrada
└── SenacGames.Desktop.csproj
```

---

### 14.6 — Autenticação via API

#### Como funciona o Cookie Authentication no Desktop

A API usa **Cookie Authentication** do ASP.NET Core Identity.
Ao contrário do JWT, o cookie é gerenciado automaticamente pelo servidor.

**Fluxo:**
1. Desktop envia `POST /api/auth/login` com email e senha (JSON)
2. A API valida e retorna um **cookie de sessão**
3. O `CookieContainer` do `HttpClientHandler` armazena o cookie
4. As próximas requisições enviam o cookie automaticamente
5. A API autentica o usuário pelo cookie em cada requisição

#### Configuração do HttpClient com CookieContainer

```csharp
// Helpers/HttpClientHelper.cs
using System.Net;

private HttpClientHelper()
{
    // CookieContainer: armazena os cookies recebidos da API
    var cookieContainer = new CookieContainer();

    var handler = new HttpClientHandler
    {
        CookieContainer = cookieContainer,
        UseCookies = true,           // gerencia cookies automaticamente
        AllowAutoRedirect = false,   // a API retorna 401, não redireciona
        // aceita SSL em desenvolvimento:
        ServerCertificateCustomValidationCallback =
            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    };

    _client = new HttpClient(handler)
    {
        BaseAddress = new Uri("https://localhost:7000"),
        Timeout = TimeSpan.FromSeconds(30)
    };
}
```

#### Tela de Login

```csharp
// Forms/LoginForm.cs
private async void BtnEntrar_Click(object? sender, EventArgs e)
{
    var (success, user, error) = await _authService.LoginAsync(
        txtEmail.Text, txtSenha.Text);

    if (success && user != null)
    {
        SessionManager.Instance.SetUser(user); // armazena na sessão
        this.Hide();
        using var mainForm = new MainForm();
        mainForm.ShowDialog();
        this.Close();
    }
    else
    {
        lblErro.Text = error; // exibe mensagem de erro
    }
}
```

---

### 14.7 — Controle de Permissões

O controle de acesso funciona em duas camadas:

1. **API**: verifica o cookie e a role (`[Authorize(Roles = "Admin")]`)
2. **Desktop**: oculta/mostra botões baseado no perfil (experiência de usuário)

#### SessionManager (Singleton)

```csharp
// Helpers/SessionManager.cs
public sealed class SessionManager
{
    public static SessionManager Instance { get; } = new();
    public UserResponseDto? CurrentUser { get; private set; }

    // Retorna true se o usuário tem a role "Admin"
    public bool IsAdmin => CurrentUser?.Roles.Contains("Admin") ?? false;

    public void SetUser(UserResponseDto user) => CurrentUser = user;
    public void Clear() => CurrentUser = null;
}
```

#### Aplicando no MainForm

```csharp
// Forms/MainForm.cs
private void ConfigurarPermissoes()
{
    bool isAdmin = SessionManager.Instance.IsAdmin;

    // Módulos exclusivos para Admin
    btnCategorias.Visible = isAdmin;
    btnUsuarios.Visible = isAdmin;
}
```

| Perfil | Dashboard | Games | Categorias | Usuários |
|--------|-----------|-------|-----------|----------|
| Admin | ✅ | ✅ CRUD | ✅ CRUD | ✅ CRUD |
| Usuário Comum | ✅ | 👁️ Leitura | ❌ | ❌ |

---

### 14.8 — UserControls: por que usar?

Em vez do padrão antigo **MDI** (Multiple Document Interface — janelas filhas),
usamos o padrão moderno de **navegação por UserControls**:

- Um painel central (`pnlConteudo`) recebe UserControls dinamicamente
- A sidebar exibe botões de navegação
- Ao clicar num botão, o UserControl anterior é removido e o novo é adicionado

**Vantagens:**
- Interface mais fluida (sem janelas sobrepostas)
- Controle total sobre o layout
- Semelhante à navegação de SPAs web
- Cada "página" é um componente isolado e reutilizável

#### Padrão de navegação no MainForm

```csharp
// Forms/MainForm.cs
private UserControl? _controlAtual;

private void Navegar(UserControl control, Guna2Button? botao = null)
{
    // Remove o controle anterior e libera recursos
    if (_controlAtual != null)
    {
        pnlConteudo.Controls.Remove(_controlAtual);
        _controlAtual.Dispose();
    }

    // Adiciona o novo UserControl preenchendo o painel
    control.Dock = DockStyle.Fill;
    pnlConteudo.Controls.Add(control);
    _controlAtual = control;

    AtualizarBotaoAtivo(botao); // destaca o botão na sidebar
}

// Uso:
btnGames.Click += (s, e) => Navegar(new GamesUserControl(), btnGames);
```

#### DashboardUserControl

Exibe métricas gerais do sistema:
- Cards com: total de games, total de categorias
- Grid com os últimos 10 games cadastrados
- Dados carregados em paralelo da API (`Task.WhenAll`)

#### GamesUserControl

CRUD completo de games:
- Listagem em `DataGridView` estilizado
- Pesquisa em tempo real (filtro em memória)
- Botões Novo / Editar / Excluir (visíveis apenas para Admin)
- `GameFormDialog` para criar e editar

#### CategoriasUserControl

CRUD de categorias:
- Listagem em `DataGridView`
- Formulário lateral inline (sem abrir nova janela)
- Validação: não permite excluir categoria com games vinculados

#### UsuariosUserControl

Gerenciamento de usuários do Identity:
- Listagem de usuários cadastrados
- Pesquisa por email
- Criar novo usuário com seleção de perfil
- Excluir usuário

---

### 14.9 — CRUD de Games via API

```csharp
// Services/GamesApiService.cs

// Listar todos os games
public async Task<List<GameResponseDto>> GetAllAsync()
{
    var games = await _http.GetAsync<List<GameResponseDto>>("/api/games");
    return games ?? new();
}

// Criar game (Admin)
public async Task<(bool, GameResponseDto?, string)> CreateAsync(CreateGameDto dto)
    => await _http.PostAsync<GameResponseDto>("/api/games", dto);

// Editar game (Admin)
public async Task<(bool, GameResponseDto?, string)> UpdateAsync(int id, UpdateGameDto dto)
    => await _http.PutAsync<GameResponseDto>($"/api/games/{id}", dto);

// Excluir game (Admin)
public async Task<(bool, string)> DeleteAsync(int id)
    => await _http.DeleteAsync($"/api/games/{id}");
```

**Campos do formulário de Game:**
- Título (obrigatório)
- Descrição
- Ano de lançamento (validado entre 1970 e ano atual + 2)
- URL da capa
- Categoria (ComboBox carregado da API)
- Destaque (CheckBox)

---

### 14.10 — CRUD de Categorias via API

```csharp
// Services/CategoriasApiService.cs

// Listar categorias
public async Task<List<CategoriaResponseDto>> GetAllAsync()
{
    var cats = await _http.GetAsync<List<CategoriaResponseDto>>("/api/categories");
    return cats ?? new();
}

// Criar categoria (Admin)
public async Task<(bool, CategoriaResponseDto?, string)> CreateAsync(CreateCategoriaDto dto)
    => await _http.PostAsync<CategoriaResponseDto>("/api/categories", dto);

// Editar categoria (Admin)
public async Task<(bool, CategoriaResponseDto?, string)> UpdateAsync(int id, UpdateCategoriaDto dto)
    => await _http.PutAsync<CategoriaResponseDto>($"/api/categories/{id}", dto);

// Excluir categoria (Admin)
public async Task<(bool, string)> DeleteAsync(int id)
    => await _http.DeleteAsync($"/api/categories/{id}");
```

**Campo do formulário:**
- Nome da categoria (obrigatório)

---

### 14.11 — CRUD de Usuários via API

O gerenciamento de usuários integra com o **ASP.NET Core Identity** já configurado na API.

**Integração com Identity:**
- Os usuários são criados e gerenciados pelo Identity
- As roles (Admin / User) são atribuídas pelo sistema
- Redefinição de senha também passa pela API

**Campos do formulário:**
- E-mail (obrigatório)
- Senha (mínimo 6 caracteres)
- Confirmação de senha
- Perfil: Admin ou Usuário Comum

**Ações disponíveis para Admin:**
- Listar usuários
- Pesquisar por email
- Criar novo usuário
- Excluir usuário
- Alterar perfil (role)
- Redefinir senha

> **Nota**: Os endpoints `/api/users` precisam ser implementados na API
> (um `UsersController`) para que o módulo de usuários funcione completamente.

---

### 14.12 — Configuração do appsettings.json do Desktop

Edite `SenacGames.Desktop/appsettings.json` com a URL da API:

```json
{
  "ApiBaseUrl": "https://localhost:7000",
  "AppSettings": {
    "AppName": "SenacGames Desktop",
    "Version": "1.0.0",
    "Timeout": 30
  }
}
```

> Verifique a porta real em `SenacGames.API/Properties/launchSettings.json`.

---

### 14.13 — Executando o Desktop

**Pré-requisito**: A API deve estar em execução antes de abrir o Desktop.

#### Opção 1 — Visual Studio

1. Defina `SenacGames.Desktop` como projeto de inicialização
2. Pressione **F5** ou clique em **Iniciar**

#### Opção 2 — PowerShell

```powershell
# Primeiro, inicie a API:
dotnet run --project SenacGames.API

# Em outro terminal, inicie o Desktop:
dotnet run --project SenacGames.Desktop
```

#### Opção 3 — Prompt de Comando (CMD)

```cmd
REM Terminal 1 — API:
dotnet run --project SenacGames.API

REM Terminal 2 — Desktop:
dotnet run --project SenacGames.Desktop
```

---

## Resumo Final

Ao concluir todos os passos deste roadmap, você terá:

- Uma solution com **6 projetos** em camadas
- Entidades Game e Category com EF Core
- Repositórios e Services organizados
- API REST com Swagger
- MVC com Views Razor e Bootstrap 5
- Autenticação com Identity (Login, Register, Roles)
- Dashboard administrativo (Web e Desktop)
- CRUD completo de Games e Categorias
- Seed Data com dados iniciais
- Design moderno baseado no protótipo Stitch
- **Cliente Desktop Windows Forms** com Guna.UI2
- **Consumo de API REST** via HttpClient com Cookie Authentication
- **Controle de permissões** por perfil (Admin / Usuário Comum)

**Parabéns!** Você construiu uma aplicação completa, profissional e multi-client do zero!
