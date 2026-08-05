// =============================================================================
// SenacGames.Application - DTOs de Usuario
// =============================================================================

namespace SenacGames.Application.DTOs
{
    /// <summary>
    /// DTO para transferência de dados de um Usuário.
    /// </summary>
    public class UsuarioDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO para criação de um novo Usuário.
    /// </summary>
    public class CreateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string ConfirmarSenha { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO para atualização de um Usuário existente.
    /// </summary>
    public class UpdateUsuarioDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Senha { get; set; } // Senha é opcional na edição
        public string? ConfirmarSenha { get; set; }
        public string Perfil { get; set; } = string.Empty;
    }
}
