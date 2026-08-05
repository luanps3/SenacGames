// =============================================================================
// SenacGames.Desktop - DTOs/AuthDtos.cs
// =============================================================================
//  CONCEITO: DTO (Data Transfer Object) do lado Desktop
//
// Estes DTOs são CÓPIAS locais dos DTOs da API.
// Por que fazer isso?
//    O Desktop não precisa referenciar o projeto SenacGames.Application
//    Segue o princípio de desacoplamento entre camadas
//    Cada camada define seus próprios contratos de dados
//
// Os campos devem ESPELHAR exatamente o que a API retorna em JSON.
// =============================================================================

namespace SenacGames.Desktop.DTOs
{
    /// <summary>
    /// DTO para envio das credenciais de login para a API.
    /// Mapeia o JSON enviado no corpo do POST /api/auth/login
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>E-mail do usuário</summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>Senha do usuário</summary>
        public string Password { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO para registro de novo usuário.
    /// Mapeia o JSON enviado no POST /api/auth/register
    /// </summary>
    public class RegisterRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO que representa o usuário autenticado retornado pela API.
    /// Mapeia o JSON retornado no POST /api/auth/login e GET /api/auth/me
    /// </summary>
    public class UserResponseDto
    {
        /// <summary>ID único do usuário no Identity</summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>E-mail do usuário</summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Lista de roles (perfis) do usuário.
        /// Exemplos: "Admin", "User"
        /// </summary>
        public List<string> Roles { get; set; } = new();

        /// <summary>
        /// Verifica se o usuário possui o perfil de Administrador.
        /// Usado para controle de acesso na interface.
        /// </summary>
        public bool IsAdmin => Roles.Contains("Admin");
    }
}
