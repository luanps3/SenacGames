# 📖 Dicionário de Termos e Dados — SenacGames

> Este documento tem o objetivo de explicar de forma clara e detalhada os principais termos técnicos, padrões de projeto e ferramentas utilizados na construção do ecossistema SenacGames, além de fornecer o dicionário de dados do banco. Ele foi feito especialmente para tirar dúvidas de alunos e desenvolvedores iniciantes.

---

## 🏛️ Padrões de Arquitetura e Projeto

### **MVC (Model-View-Controller)**
É um padrão de arquitetura de software que divide a aplicação em três partes principais:
- **Model (Modelo):** Representa os dados e a lógica de negócios da aplicação. No nosso projeto, o Model muitas vezes é substituído pela combinação de *Entities*, *ViewModels* e *DTOs*.
- **View (Visualização):** É a interface com o usuário. No projeto Web, são as páginas HTML (arquivos `.cshtml`) geradas pelo Razor.
- **Controller (Controladora):** É a "maestra" da aplicação. Ela recebe as requisições do usuário, processa o pedido (comunicando-se com a API) e decide qual *View* será mostrada de volta ao usuário.

### **API (Application Programming Interface)**
No contexto web (API REST), é um conjunto de regras e endereços (endpoints) que permite que diferentes aplicações conversem entre si. A `SenacGames.API` não tem interface gráfica (telas); ela recebe pedidos na forma de URLs e devolve respostas no formato de texto estruturado (geralmente JSON). Isso permite que tanto a aplicação Web (MVC) quanto a aplicação Desktop (Windows Forms) usem as mesmas regras de negócio.

### **Injeção de Dependência (Dependency Injection - DI)**
É uma técnica onde um objeto não cria os recursos que ele precisa para funcionar, mas sim os recebe "injetados" (geralmente através do construtor). Por exemplo, um `GamesController` precisa de um `IGameService`. Em vez de o Controller fazer `new GameService()`, o próprio ASP.NET cria o serviço e o "injeta" no Controller.

---

## 📦 Estruturas de Dados

### **Entity (Entidade)**
É uma classe que representa uma tabela do banco de dados (ex: `Game`, `Category`). Ela é o núcleo da aplicação e fica na camada de *Domain*. Possui regras rígidas e espelha exatamente a estrutura do banco.

### **DTO (Data Transfer Object)**
Objeto de Transferência de Dados. É uma classe simples, sem lógica ou comportamento, usada apenas para carregar dados entre diferentes partes do sistema (por exemplo, da API para o Desktop). Serve para não expormos a *Entity* diretamente. 

### **ViewModel**
Modelo de Visualização. É uma classe criada especificamente para transportar múltiplos dados misturados do Controller para a View. 

---

## 🛠️ Ferramentas e Frameworks

### **ASP.NET Core**
É o framework principal da Microsoft para construção de aplicações Web e APIs. É multiplataforma e extremamente rápido.

### **Entity Framework Core (EF Core)**
É um **ORM** (Object-Relational Mapper). Ele permite que o programador interaja com o banco de dados usando código C# em vez de escrever comandos SQL.
- **DbContext:** É a classe principal do EF Core que representa a sessão com o banco de dados (no nosso caso, o `SenacGamesDbContext`).
- **Migrations:** É o sistema de "controle de versão" do banco de dados.

### **ASP.NET Core Identity**
É o sistema de segurança nativo do ASP.NET Core. Ele cuida de todo o trabalho pesado envolvendo autenticação e autorização.

### **JWT (JSON Web Token)**
Método de autenticação utilizado pela API. Quando o usuário faz login, a API devolve um Token de texto. O cliente (UI ou Desktop) deve enviar este Token nas próximas requisições para provar que está logado.

### **Swagger / Swashbuckle**
É uma ferramenta que lê o código da nossa API e gera automaticamente uma página web documentando todos os nossos endpoints (URLs).

### **Windows Forms (WinForms)**
É uma tecnologia clássica do .NET para criar aplicações Desktop para Windows.

---

## 🌐 Comunicação e Internet

### **HTTP (Hypertext Transfer Protocol)**
É a linguagem usada para comunicação na internet. Quando o Desktop ou o MVC querem falar com a API, eles enviam requisições HTTP:
- **GET:** Pede dados (ex: "me dê a lista de games").
- **POST:** Envia dados novos (ex: "cadastre esse novo game").
- **PUT:** Atualiza dados existentes (ex: "mude o nome do game de ID 5").
- **DELETE:** Apaga dados (ex: "exclua o game de ID 5").

### **HttpClient**
É a classe do C# usada para fazer essas requisições HTTP. É através do `HttpClient` que o nosso Desktop e a nossa UI conversam com a nossa API.

### **JSON (JavaScript Object Notation)**
É o formato de texto universalmente utilizado para troca de dados entre sistemas. 

---

## ⚙️ Conceitos de C# Avançado

### **Programação Assíncrona (async / await / Task)**
- O termo **`async`** indica que um método pode rodar em segundo plano sem congelar a tela. 
- O termo **`await`** diz ao programa para aguardar a resposta sem bloquear o sistema.
- **`Task`** representa essa tarefa.

---

## 🧩 Programação Orientada a Objetos (POO)

A POO é o paradigma principal do C# e do .NET. É uma forma de programar trazendo conceitos do mundo real para o código, utilizando **Classes**, **Objetos**, **Atributos**, **Encapsulamento**, **Herança** e **Polimorfismo**.

---

## 📊 Dicionário de Dados do Banco

Este trecho detalha as tabelas, colunas, tipos e descrições do modelo de dados utilizado pelo SenacGames através do Entity Framework Core. 

### Tabela: `AspNetUsers` (Identity)
A tabela que gerencia os usuários e permissões do sistema pelo ASP.NET Core Identity.

| Coluna | Tipo C# / BD | Descrição | Restrições |
| :--- | :--- | :--- | :--- |
| `Id` | `string` / `NVARCHAR(450)` | Identificador único gerado automaticamente. | Primary Key |
| `UserName` | `string` / `NVARCHAR(256)` | Nome de usuário no sistema. | Obrigatório |
| `Email` | `string` / `NVARCHAR(256)` | E-mail para acesso. | Unique, Obrigatório |
| `PasswordHash` | `string` / `NVARCHAR(MAX)` | O hash criptografado da senha do usuário. | Obrigatório |

### Tabela: `Category`
Agrupa games por gêneros como Ação, RPG, Estratégia, etc.

| Coluna | Tipo C# / BD | Descrição | Restrições |
| :--- | :--- | :--- | :--- |
| `Id` | `int` / `INT` | Identificador da categoria. | Primary Key, Auto Increment |
| `Name` | `string` / `NVARCHAR(MAX)` | Nome da Categoria (Ex: RPG). | Obrigatório |

### Tabela: `Game`
O conteúdo principal da plataforma SenacGames.

| Coluna | Tipo C# / BD | Descrição | Restrições |
| :--- | :--- | :--- | :--- |
| `Id` | `int` / `INT` | Identificador do game. | Primary Key, Auto Increment |
| `Title` | `string` / `NVARCHAR(MAX)` | Título principal do game. | Obrigatório |
| `Description` | `string` / `NVARCHAR(MAX)` | Sinopse ou descrição do game. | Obrigatório |
| `ReleaseYear` | `int` / `INT` | Ano de lançamento original. | Obrigatório |
| `CoverImageUrl` | `string` / `NVARCHAR(MAX)` | URL ou Path da imagem da capa. | Opcional |
| `IsFeatured` | `bool` / `BIT` | Indica se o jogo está nos destaques. | Padrão `false` |
| `CategoryId` | `int` / `INT` | Referência da categoria. | Foreign Key -> `Category` |
| `CreatedAt` | `DateTime` / `DATETIME2` | Data de criação do registro. | Obrigatório |

### 🔗 Relacionamentos Mapeados
- **`Category` 1 : N `Game`**
