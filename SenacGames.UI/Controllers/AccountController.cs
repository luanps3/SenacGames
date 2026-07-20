// =============================================================================
// SenacGames.UI - AccountController (HTTP API Proxy)
// =============================================================================

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;

namespace SenacGames.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            // O AccountController usa o HttpClient Base sem o ApiCookieHandler,
            // pois o login é justamente quem VAI PEGAR o cookie.
            _httpClient = httpClientFactory.CreateClient("ApiClientAuth");
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDto dto, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            // Envia o login para a API
            var response = await _httpClient.PostAsJsonAsync("/api/auth/login", dto);

            if (response.IsSuccessStatusCode)
            {
                var userDto = await response.Content.ReadFromJsonAsync<UserDto>();
                
                // Extrai o Cookie retornado pela API
                var apiCookieString = "";
                if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
                {
                    apiCookieString = cookies.FirstOrDefault(c => c.StartsWith(".AspNetCore.Identity.Application="));
                    if (!string.IsNullOrEmpty(apiCookieString))
                    {
                        // Opcional: extrair apenas o valor até o primeiro ponto e vírgula
                        apiCookieString = apiCookieString.Split(';')[0];
                    }
                }

                // Cria os Claims do usuário local no MVC
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userDto!.Id),
                    new Claim(ClaimTypes.Name, userDto.Email),
                    new Claim(ClaimTypes.Email, userDto.Email),
                    // Guarda o cookie da API nos claims para uso posterior
                    new Claim("ApiCookie", apiCookieString ?? "")
                };

                foreach (var role in userDto.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                // Faz login no MVC
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Email ou senha inválidos na API.");
            return View(dto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (dto.Password != dto.ConfirmPassword)
            {
                ModelState.AddModelError(string.Empty, "As senhas não coincidem.");
                return View(dto);
            }

            // Para registro, a API provavelmente tem um endpoint /api/auth/register
            // Vamos assumir que a API não loga automaticamente o usuário recém-criado, 
            // então redirecionamos para o Login local
            
            // var response = await _httpClient.PostAsJsonAsync("/api/auth/register", dto);
            // if (response.IsSuccessStatusCode) { return RedirectToAction("Login"); }
            
            ModelState.AddModelError(string.Empty, "Registro via API não está implementado neste exemplo.");
            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
