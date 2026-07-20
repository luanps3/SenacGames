# SenacGames

> Aplicação completa ASP.NET Core em arquitetura de camadas para ensino.
> Inclui API REST, aplicação MVC e cliente Desktop Windows Forms.

## Sobre o Projeto

O **SenacGames** é um catálogo de jogos desenvolvido como projeto didático para ensino de:
- ASP.NET Core MVC
- Arquitetura em camadas
- Entity Framework Core
- ASP.NET Core Identity
- API REST
- CRUD completo
- Razor Views
- Bootstrap 5
- Windows Forms
- Consumo de API via HttpClient

## Tecnologias Utilizadas

| Tecnologia | Versão | Uso |
|------------|--------|-----|
| .NET | 8.0 | Framework principal |
| ASP.NET Core MVC | 8.0 | Aplicação web (UI) |
| ASP.NET Core Web API | 8.0 | API REST |
| Entity Framework Core | 8.0.11 | ORM / Acesso a dados |
| SQL Server LocalDB | — | Banco de dados |
| ASP.NET Core Identity | 8.0 | Autenticação |
| Bootstrap | 5.3 | Framework CSS |
| Bootstrap Icons | 1.11 | Ícones |
| Swagger | 6.5 | Documentação da API |
| Windows Forms | 8.0 | Aplicação Desktop |
| Guna.UI2.WinForms | 2.0.4.8 | Componentes visuais do Desktop |

## Estrutura das Camadas

```
SenacGames/
├── SenacGames.Domain        → Entidades, Interfaces
├── SenacGames.Application   → Services, DTOs, ViewModels
├── SenacGames.Infrastructure → DbContext, Repositories, Identity, Migrations
├── SenacGames.API           → Controllers REST, Swagger
├── SenacGames.UI            → Controllers MVC, Views Razor, Bootstrap
└── SenacGames.Desktop       → Windows Forms, Guna.UI2, cliente HTTP da API
```

### Responsabilidade de cada camada

#### SenacGames.Domain
Define as entidades (`Game`, `Category`) e as interfaces dos repositórios.
Não depende de nenhuma outra camada — é o núcleo da aplicação.

#### SenacGames.Application
Contém os serviços que orquestram as operações, DTOs para transferência de dados e ViewModels para as Views.
Depende apenas do Domain.

#### SenacGames.Infrastructure
Implementa o acesso a dados com Entity Framework Core, os repositórios, o Identity e o Seed Data.
Depende do Domain e Application.

#### SenacGames.API
Expõe os endpoints REST com Swagger para testes. Recebe requisições HTTP e delega ao Application.
Depende do Application e Infrastructure.

#### SenacGames.UI
Aplicação MVC com Razor Views e Bootstrap para a interface do usuário web.
Agora atua como **Cliente HTTP** consumindo a API — **não acessa o banco diretamente**.
Depende apenas do Application (para DTOs/Interfaces) e não referencia a Infrastructure.

#### SenacGames.Desktop
Aplicação **Windows Forms** utilizando **Guna.UI2** como cliente administrativo.
Consome exclusivamente a API existente via HTTP — **não acessa o banco diretamente**.
Não referencia Infrastructure, Domain nem Application.

## Fluxo da Solução

### Fluxo via UI (Web)

```
Usuário (Navegador)
        ↓
SenacGames.UI  (ASP.NET Core MVC)
        ↓  HTTP / Cookie Proxy
SenacGames.API  (REST)
        ↓
SenacGames.Application  (Services / DTOs)
        ↓
SenacGames.Infrastructure  (EF Core / Identity)
        ↓
Banco de Dados (SQL Server)
```

### Fluxo via Desktop

```
Usuário (Windows)
        ↓
SenacGames.Desktop  (Windows Forms + Guna.UI2)
        ↓  HTTP / Cookie Auth
SenacGames.API  (REST)
        ↓
SenacGames.Application  (Services / DTOs)
        ↓
SenacGames.Infrastructure  (EF Core / Identity)
        ↓
Banco de Dados (SQL Server)
```

> ⚠️ **Importante — Regras dos Clientes (UI e Desktop):**
> - Eles **NÃO** acessam o banco de dados diretamente.
> - Eles **NÃO** referenciam `SenacGames.Infrastructure`.
> - Eles **NÃO** possuem regras de negócio de banco próprias.
> - Toda comunicação ocorre exclusivamente através dos endpoints da API.

## Dependências por Projeto

### SenacGames.UI
- ASP.NET Core MVC
- Bootstrap 5.3
- Bootstrap Icons 1.11

### SenacGames.API
- ASP.NET Core Web API
- Swagger / Swashbuckle 6.5

### SenacGames.Infrastructure
- Entity Framework Core 8.0.11
- EF Core SQL Server
- ASP.NET Core Identity

### SenacGames.Desktop
- .NET 8 Windows Forms
- Guna.UI2.WinForms 2.0.4.8
- HttpClient (nativo do .NET)
- System.Text.Json (nativo do .NET)

## Instalação do Guna.UI2

Para instalar o Guna.UI2 no projeto `SenacGames.Desktop`:

#### 🖥️ Opção 1 — Console do Gerenciador de Pacotes (Package Manager Console)

Acesse: **Ferramentas → Gerenciador de Pacotes NuGet → Console do Gerenciador de Pacotes**

> **IMPORTANTE**: No dropdown "Projeto padrão", selecione **SenacGames.Desktop**.

```powershell
Install-Package Guna.UI2.WinForms
```

#### Opção 2 — PowerShell

```powershell
dotnet add SenacGames.Desktop package Guna.UI2.WinForms
```

#### Opção 3 — CMD

```cmd
dotnet add SenacGames.Desktop package Guna.UI2.WinForms
```

## Como Executar

### Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server LocalDB](https://docs.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb) (vem com o Visual Studio)

### Passo 1: Clonar o repositório
```bash
git clone https://github.com/seu-usuario/SenacGames.git
cd SenacGames
```

### Passo 2: Restaurar pacotes
```bash
dotnet restore
```

### Passo 3: Criar o banco de dados

#### Opção 1 — Package Manager Console (Visual Studio)
```powershell
Update-Database -Project SenacGames.Infrastructure -StartupProject SenacGames.API
```

#### Opção 2 — PowerShell / CMD
```bash
dotnet ef database update --project SenacGames.Infrastructure --startup-project SenacGames.API
```

> **Nota:** O banco é criado automaticamente na primeira execução (o Seed Data aplica as migrations).

### Passo 4: Executar a aplicação

#### Rodar a API (Swagger):
```bash
dotnet run --project SenacGames.API
```
Acesse: `https://localhost:5001/swagger`

#### Rodar a UI (MVC):
```bash
dotnet run --project SenacGames.UI
```
Acesse: `https://localhost:5002` (ou a porta indicada no terminal)

#### Rodar o Desktop (Windows Forms):
1. Certifique-se de que a **API está em execução**
2. Abra `SenacGames.Desktop/appsettings.json` e confirme a porta da API
3. Execute:
```bash
dotnet run --project SenacGames.Desktop
```
Ou no Visual Studio: defina `SenacGames.Desktop` como projeto de inicialização e pressione **F5**.

## Usuário Administrador

O sistema cria automaticamente um usuário admin:

| Campo | Valor |
|-------|-------|
| Email | admin@senacgames.com |
| Senha | Admin@123 |
| Role | Admin |

## Controle de Perfis (Desktop)

| Módulo | Admin | Usuário Comum |
|--------|-------|---------------|
| Dashboard | ✅ | ✅ |
| Games (CRUD completo) | ✅ | 👁️ Somente leitura |
| Categorias | ✅ | ❌ |
| Usuários | ✅ | ❌ |
| Perfil | ✅ | ✅ |

## Endpoints da API

### Games
| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/games` | Lista todos os games |
| GET | `/api/games/{id}` | Busca game por ID |
| POST | `/api/games` | Cria novo game (Admin) |
| PUT | `/api/games/{id}` | Atualiza game (Admin) |
| DELETE | `/api/games/{id}` | Remove game (Admin) |

### Categorias
| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/categories` | Lista categorias |
| POST | `/api/categories` | Cria categoria (Admin) |
| PUT | `/api/categories/{id}` | Atualiza categoria (Admin) |
| DELETE | `/api/categories/{id}` | Remove categoria (Admin) |

### Autenticação
| Método | Endpoint | Descrição |
|--------|----------|-----------|
| POST | `/api/auth/register` | Registra usuário |
| POST | `/api/auth/login` | Faz login |
| POST | `/api/auth/logout` | Faz logout |
| GET | `/api/auth/me` | Dados do usuário |

## Configuração do Banco

A connection string está em `appsettings.json`:

```json
{
 "ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SenacGamesDb;Trusted_Connection=True;MultipleActiveResultSets=true"
 }
}
```

Para usar outro servidor SQL Server, altere a connection string nos projetos **API** e **UI**.

## Migrations

### Criar nova migration:

#### Package Manager Console:
```powershell
Add-Migration NomeDaMigration -Project SenacGames.Infrastructure -StartupProject SenacGames.API
```

#### PowerShell:
```bash
dotnet ef migrations add NomeDaMigration --project SenacGames.Infrastructure --startup-project SenacGames.API
```

### Aplicar migrations:

#### Package Manager Console:
```powershell
Update-Database -Project SenacGames.Infrastructure -StartupProject SenacGames.API
```

#### PowerShell:
```bash
dotnet ef database update --project SenacGames.Infrastructure --startup-project SenacGames.API
```

## Documentação Adicional

- [`SenacGames.Desktop/README_DESKTOP.md`](SenacGames.Desktop/README_DESKTOP.md) — Documentação específica do Desktop
- [`SenacGames.Desktop/DesktopRoadmap.md`](SenacGames.Desktop/DesktopRoadmap.md) — Guia passo a passo para construir o Desktop
- [`ROADMAP.md`](ROADMAP.md) — Guia completo para criar a solução do zero

## Licença

Projeto didático desenvolvido para o Senac — uso educacional.
