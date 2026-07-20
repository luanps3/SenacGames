# 📖 Dicionário de Termos — SenacGames

> Este documento tem o objetivo de explicar de forma clara e detalhada os principais termos técnicos, padrões de projeto e ferramentas utilizados na construção do ecossistema SenacGames. Ele foi feito especialmente para tirar dúvidas de alunos e desenvolvedores iniciantes.

---

## 🏛️ Padrões de Arquitetura e Projeto

### **MVC (Model-View-Controller)**
É um padrão de arquitetura de software que divide a aplicação em três partes principais:
- **Model (Modelo):** Representa os dados e a lógica de negócios da aplicação. No nosso projeto, o Model muitas vezes é substituído pela combinação de *Entidades*, *ViewModels* e *DTOs*.
- **View (Visualização):** É a interface com o usuário. No projeto Web, são as páginas HTML (arquivos `.cshtml`) geradas pelo Razor.
- **Controller (Controladora):** É a "maestra" da aplicação. Ela recebe as requisições do usuário (quando ele clica em um botão ou acessa uma URL), processa o pedido (comunicando-se com a API ou o Banco de Dados) e decide qual *View* será mostrada de volta ao usuário.

### **API (Application Programming Interface)**
No contexto web (API REST), é um conjunto de regras e endereços (endpoints) que permite que diferentes aplicações conversem entre si. A `SenacGames.API` não tem interface gráfica (telas); ela recebe pedidos na forma de URLs e devolve respostas no formato de texto estruturado (geralmente JSON). Isso permite que tanto a aplicação Web (MVC) quanto a aplicação Desktop (Windows Forms) usem as mesmas regras de negócio.

### **BFF (Backend for Frontend)**
Um padrão onde criamos um "backend" cujo único propósito é servir de ponte para uma interface de usuário específica ("frontend"). No nosso caso atual, o `SenacGames.UI` atua como um BFF: ele tem Controllers e roda em um servidor, mas não acessa o banco de dados; ele apenas formata os dados vindos da API para exibi-los no navegador.

### **Injeção de Dependência (Dependency Injection - DI)**
É uma técnica onde um objeto não cria os recursos que ele precisa para funcionar, mas sim os recebe "injetados" (geralmente através do construtor). Por exemplo, um `GamesController` precisa de um `IGameService`. Em vez de o Controller fazer `new GameService()`, o próprio ASP.NET cria o serviço e o "injeta" no Controller. Isso facilita muito a manutenção e os testes.

---

## 📦 Estruturas de Dados

### **Entity (Entidade)**
É uma classe que representa uma tabela do banco de dados (ex: `Game`, `Category`). Ela é o núcleo da aplicação e fica na camada de *Domain*. Possui regras rígidas e espelha exatamente a estrutura do banco.

### **DTO (Data Transfer Object)**
Objeto de Transferência de Dados. É uma classe simples, sem lógica ou comportamento, usada apenas para carregar dados entre diferentes partes do sistema (por exemplo, da API para o Desktop). Serve para não expormos a *Entity* diretamente. Um `CreateGameDto`, por exemplo, contém apenas os campos necessários para criar um jogo, sem o ID (pois o ID ainda não existe).

### **ViewModel**
Modelo de Visualização. É uma classe criada especificamente para transportar múltiplos dados misturados do Controller para a View. Por exemplo, a página inicial pode precisar de uma lista de jogos em destaque E uma lista de categorias. Criamos um `HomeViewModel` que junta essas duas listas em um único objeto para entregar à View.

---

## 🛠️ Ferramentas e Frameworks

### **ASP.NET Core**
É o framework principal da Microsoft para construção de aplicações Web e APIs. É multiplataforma, extremamente rápido e de código aberto.

### **Entity Framework Core (EF Core)**
É um **ORM** (Object-Relational Mapper). Ele permite que o programador interaja com o banco de dados usando código C# em vez de escrever comandos SQL (SELECT, INSERT, UPDATE, DELETE). O EF Core traduz os comandos C# para a linguagem que o banco de dados entende.
- **DbContext:** É a classe principal do EF Core que representa a sessão com o banco de dados (no nosso caso, o `SenacGamesDbContext`).
- **Migrations:** É o sistema de "controle de versão" do banco de dados. Quando criamos uma nova classe/entidade no código, rodamos um comando que gera uma "Migration", a qual atualiza o banco de dados para criar a nova tabela automaticamente.

### **ASP.NET Core Identity**
É o sistema de segurança nativo do ASP.NET Core. Ele cuida de todo o trabalho pesado envolvendo autenticação (quem é o usuário) e autorização (o que o usuário pode fazer), incluindo criação de tabelas de usuário, criptografia e validação de senhas, e gerenciamento de perfis (Roles).

### **Swagger / Swashbuckle**
É uma ferramenta que lê o código da nossa API e gera automaticamente uma página web documentando todos os nossos endpoints (URLs). Ela também permite que testemos a API clicando em botões sem precisar escrever nenhum código cliente.

### **Windows Forms (WinForms)**
É uma tecnologia clássica do .NET para criar aplicações Desktop para Windows (aquelas que instalam no computador, com janelas e botões nativos).

### **Guna.UI2**
É uma biblioteca de terceiros instalada no Windows Forms para modernizar seu visual. Ela fornece botões arredondados, painéis com sombra e componentes muito mais bonitos que os originais cinzas do Windows.

---

## 🌐 Comunicação e Internet

### **HTTP (Hypertext Transfer Protocol)**
É a linguagem usada para comunicação na internet. Quando o Desktop ou o MVC querem falar com a API, eles enviam requisições HTTP. Elas têm "verbos" (métodos) principais:
- **GET:** Pede dados (ex: "me dê a lista de jogos").
- **POST:** Envia dados novos (ex: "cadastre esse novo jogo").
- **PUT:** Atualiza dados existentes (ex: "mude o preço do jogo de ID 5").
- **DELETE:** Apaga dados (ex: "exclua o jogo de ID 5").

### **HttpClient**
É a classe do C# usada para fazer essas requisições HTTP. É através do `HttpClient` que o nosso Desktop e a nossa UI conversam com a nossa API.

### **JSON (JavaScript Object Notation)**
É o formato de texto universalmente utilizado hoje em dia para troca de dados entre sistemas. A API pega um objeto C# e o transforma em JSON (um texto estruturado com chaves e valores) antes de enviá-lo pela rede. Quando o cliente (Desktop/UI) recebe o JSON, ele o transforma de volta em um objeto C#.

### **Cookie**
É um pequeno pedaço de texto que um servidor pede para o navegador (ou para o Desktop) guardar. No contexto do `SenacGames`, usamos cookies para **Autenticação de Sessão**. Quando você faz login, a API verifica a senha e diz "Sim, você é você. Guarde este crachá (Cookie)". Em todas as requisições seguintes, o cliente mostra esse crachá, provando que está logado.

### **Claims**
Em termos de segurança, "Claim" significa "Afirmação". Em vez de apenas saber o ID do usuário, a autenticação moderna cria uma carteira de identidade digital cheia de Claims. Exemplo: "O Nome desse usuário é Admin", "O Email desse usuário é admin@senac.br", "O Papel (Role) desse usuário é Administrador". 

---

## ⚙️ Conceitos de C# Avançado

### **Programação Assíncrona (async / await / Task)**
Na computação, operações como "ir buscar dados no banco" ou "fazer um download via internet" demoram muito (em tempo de máquina). Se o programa ficasse parado esperando, a tela congelaria. 
- O termo **`async`** indica que um método pode rodar em segundo plano sem congelar a tela. 
- O termo **`await`** diz ao programa: "Pode fazer outras coisas enquanto eu espero o banco de dados responder. Me chame de volta quando acabar". 
- **`Task`** representa essa tarefa que está acontecendo assincronamente.

### **Middleware**
São "pedágios" pelo qual uma requisição web passa dentro da API antes de chegar à Controller. Por exemplo, quando o usuário acessa `/api/games`, a requisição passa pelo Middleware de Log (que anota que alguém acessou), pelo Middleware de Autenticação (que checa o Cookie), pelo Middleware de CORS, até finalmente chegar no código que processa o pedido.

### **Singleton, Scoped, Transient (Ciclos de vida de injeção)**
Quando o ASP.NET cria serviços (via Injeção de Dependência), ele decide quanto tempo eles vão viver:
- **Transient:** Cria um novo objeto **toda vez** que alguém pedir.
- **Scoped:** Cria um novo objeto **por requisição web**. (Ideal para conexão com banco de dados).
- **Singleton:** Cria um objeto único quando o programa inicia e **todo mundo usa o mesmo** para sempre. (Ideal para configurações estáticas).
---

## 🧩 Programação Orientada a Objetos (POO)

A POO é o paradigma principal do C# e do .NET. É uma forma de programar trazendo conceitos do mundo real para o código.

### **Classe**
É um "molde" ou "planta baixa" para criar coisas. Em C#, uma classe define quais informações e comportamentos um certo tipo de coisa terá. Exemplo: A classe `Game` define que todo jogo terá um Título, um Preço e um Ano de Lançamento.

### **Objeto**
É a coisa real criada a partir da Classe. Se a Classe `Game` é a planta baixa, o Objeto é a casa construída. Você pode ter vários objetos diferentes da mesma classe (ex: "The Witcher 3" e "Minecraft" são dois objetos distintos da classe `Game`). Em C#, criamos objetos na memória usando a palavra `new`.

### **Atributo / Propriedade**
São as características de uma Classe. São as variáveis que guardam os dados de um objeto. Na classe `Game`, `Title` e `Price` são propriedades.

### **Valor**
É o dado real que está guardado dentro de um Atributo de um Objeto em um determinado momento. Enquanto o atributo é `Title` (a "caixa"), o valor é `"Minecraft"` (o que está "dentro da caixa").

### **Encapsulamento**
É o princípio de "esconder" os detalhes internos de como uma classe funciona, protegendo seus dados para que não sejam alterados de forma indevida de fora. Em C#, fazemos isso usando modificadores de acesso como `private` (só a própria classe vê) e `public` (todos veem), e usando métodos (getters/setters) para controlar quem pode ler ou alterar os valores.

### **Herança**
É a capacidade de uma classe "herdar" características (atributos e métodos) de outra classe. Isso evita repetição de código. Por exemplo, se temos uma classe `Controller` base no ASP.NET, nossa `GamesController` herda dela, ganhando automaticamente todos os superpoderes de um controlador web sem precisarmos escrever tudo do zero. Em C#, a herança é indicada pelo símbolo `:` (dois pontos).

### **Polimorfismo**
Vem do grego "muitas formas". É a capacidade de um objeto poder ser tratado como se fosse de outro tipo (graças à Herança ou Interfaces) ou a capacidade de um método ter comportamentos diferentes dependendo de quem o chama. Exemplo prático: temos uma interface `IGameService`. Em tempo de execução, o polimorfismo permite que o .NET injete a classe `HttpGameService` no lugar dela sem que o programa quebre, pois ambas têm a mesma "forma" (os mesmos métodos).

---

## 🐙 Controle de Versão

### **Git**
É um sistema de controle de versão. Imagine que ele é uma "máquina do tempo" para o seu código. Ele rastreia cada alteração que você faz em cada arquivo, permitindo que você desfaça erros, veja quem alterou o que (e quando), e trabalhe em equipe sem que uma pessoa apague o código da outra. Tudo isso funciona offline no seu computador.

### **GitHub**
Não confunda com Git! Enquanto o Git é o motor que roda no seu computador local, o **GitHub** é um site (uma rede social corporativa para desenvolvedores) que hospeda os seus repositórios Git na nuvem. Ele serve como backup seguro e plataforma para que outras pessoas visualizem e colaborem com o seu projeto.

---

*Dicionário mantido para fins didáticos no Projeto SenacGames.*
