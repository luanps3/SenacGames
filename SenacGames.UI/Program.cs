// =============================================================================
// SenacGames.UI - Program.cs
// =============================================================================

using Microsoft.AspNetCore.Authentication.Cookies;
using SenacGames.Application.Interfaces;
using SenacGames.UI.Helpers;
using SenacGames.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// =====================================================================
// AUTENTICAÇÃO MVC NATIVA
// =====================================================================
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

// Permite acessar o HttpContext (necessário para o ApiCookieHandler)
builder.Services.AddHttpContextAccessor();

// =====================================================================
// HTTP CLIENTS & SERVIÇOS DA API
// =====================================================================
// Registra o Handler que injeta o Cookie
builder.Services.AddTransient<ApiCookieHandler>();

// Resolve a URL dinamicamente via ApiEndpointResolver
var apiBaseUrl = AppConfig.ApiBaseUrl;

// Cliente para autenticação (sem interceptador)
builder.Services.AddHttpClient("ApiClientAuth", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

// Cliente padrão para serviços (com interceptador de cookie)
builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
})
.AddHttpMessageHandler<ApiCookieHandler>();

// Serviços da UI consumindo a API
builder.Services.AddScoped<IGameService>(sp => 
    new HttpGameService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiClient")));

builder.Services.AddScoped<ICategoryService>(sp => 
    new HttpCategoryService(sp.GetRequiredService<IHttpClientFactory>().CreateClient("ApiClient")));

// =====================================================================
// MVC
// =====================================================================
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Removemos a chamada do SeedData.SeedAsync pois o banco não pertence mais à UI

app.Run();
