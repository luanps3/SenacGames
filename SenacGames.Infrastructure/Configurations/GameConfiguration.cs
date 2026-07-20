// =============================================================================
// SenacGames.Infrastructure - Configuração da entidade Game (Fluent API)
// =============================================================================
//  CONCEITO: IEntityTypeConfiguration<T>
// Esta classe define as regras de mapeamento da entidade Game para o banco.
// Usando Fluent API, podemos definir:
// - Tamanho máximo de campos (MaxLength)
// - Campos obrigatórios (IsRequired)
// - Relacionamentos entre tabelas
// - Nomes de tabelas e colunas
// =============================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;

namespace SenacGames.Infrastructure.Configurations
{
    /// <summary>
    /// Configuração Fluent API da entidade Game.
    /// </summary>
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            // Define a chave primária
            builder.HasKey(g => g.Id);

            // Configurações dos campos
            builder.Property(g => g.Title)
                .IsRequired()           // Campo obrigatório
                .HasMaxLength(200);     // Máximo de 200 caracteres

            builder.Property(g => g.Description)
                .HasMaxLength(2000);    // Máximo de 2000 caracteres

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(500);

            // =====================================================================
            //  CONCEITO: Configuração de Relacionamento (Fluent API)
            // Um Game pertence a UMA Category (relação N:1).
            // Uma Category possui MUITOS Games (relação 1:N).
            // HasOne  WithMany  HasForeignKey
            // =====================================================================
            builder.HasOne(g => g.Category)       // Um Game tem UMA Category
                .WithMany(c => c.Games)            // Uma Category tem MUITOS Games
                .HasForeignKey(g => g.CategoryId)  // A FK é CategoryId
                .OnDelete(DeleteBehavior.Restrict); // Não permite deletar categoria com games
        }
    }
}
