// =============================================================================
// SenacGames.API - Program.cs
// =============================================================================
//  CONCEITO IMPORTANTE: Program.cs
// Este é o PONTO DE ENTRADA da aplicação API.
// Aqui configuramos todos os serviços (DI), middlewares e a pipeline HTTP.
//
// O que é configurado aqui:
// 1. Entity Framework Core (conexão com banco de dados)
// 2. ASP.NET Core Identity (autenticação e autorização)
// 3. Dependency Injection (repositórios e serviços)
// 4. Swagger (documentação da API)
// 5. CORS (permissões de acesso cross-origin)
// =============================================================================

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SenacGames.Application.Interfaces;
using SenacGames.Application.Services;
using SenacGames.Domain.Interfaces;
using SenacGames.Infrastructure.Context;
using SenacGames.Infrastructure.Identity;
using SenacGames.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// =====================================================================
// 1. ENTITY FRAMEWORK CORE — Configuração do banco de dados
// =====================================================================
//  CONCEITO: AddDbContext registra o DbContext no container de DI.
// UseSqlServer configura o Entity Framework para usar o SQL Server.
// A connection string é lida do arquivo appsettings.json.
// =====================================================================
builder.Services.AddDbContext<SenacGamesDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// =====================================================================
// 2. ASP.NET CORE IDENTITY — Autenticação e Autorização
// =====================================================================
//  CONCEITO: Identity é o sistema de autenticação do ASP.NET Core.
// Ele gerencia: usuários, senhas, roles, claims, login, logout, etc.
// AddIdentity registra os serviços do Identity no container de DI.
// AddEntityFrameworkStores conecta o Identity ao banco via EF Core.
// =====================================================================
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    // Configurações de senha (simplificadas para ensino)
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<SenacGamesDbContext>()
.AddDefaultTokenProviders();

// Configuração de Cookie Authentication para a API
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };
    options.Events.OnRedirectToAccessDenied = context =>
    {
        context.Response.StatusCode = 403;
        return Task.CompletedTask;
    };
});

// =====================================================================
// 3. DEPENDENCY INJECTION — Registro de Repositórios e Serviços
// =====================================================================
//  CONCEITO: Dependency Injection (DI)
// AddScoped registra um serviço com ciclo de vida "por requisição".
// Isso significa que uma nova instância é criada para cada requisição HTTP.
//
// Exemplo: quando um controller precisa do IGameService,
// o .NET automaticamente cria um GameService e injeta no construtor.
// =====================================================================
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// =====================================================================
// 4. CONTROLLERS
// =====================================================================
builder.Services.AddControllers();

// =====================================================================
// 5. SWAGGER — Documentação automática da API
// =====================================================================
//  CONCEITO: Swagger gera automaticamente uma interface visual
// para testar os endpoints da API no navegador.
// Acesse: https://localhost:PORTA/swagger
// =====================================================================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "SenacGames API",
        Version = "v1",
        Description = "API REST do sistema SenacGames — Catálogo de Games para ensino de ASP.NET Core"
    });
});

// =====================================================================
// 6. CORS — Permite requisições de outras origens
// =====================================================================
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// =====================================================================
// PIPELINE DE MIDDLEWARES
// =====================================================================
//  CONCEITO: Middlewares são executados em sequência para cada requisição.
// A ordem importa! Cada middleware processa a requisição e passa adiante.
// =====================================================================

if (app.Environment.IsDevelopment())
{
    // Swagger só é habilitado em ambiente de desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");

//  IMPORTANTE: UseAuthentication ANTES de UseAuthorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// =====================================================================
// SEED DATA — Popula o banco com dados iniciais
// =====================================================================
//  CONCEITO: O seed é executado na inicialização da aplicação.
// Ele cria categorias, games de exemplo e o usuário admin.
// =====================================================================
await SeedData.SeedAsync(app.Services);

app.Run();
