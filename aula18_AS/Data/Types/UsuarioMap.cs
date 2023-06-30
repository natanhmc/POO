using aula18_AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula18_AS.Data.Types
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(i => i.Senha)
                .HasColumnName("senha")
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(i => i.CPF)
                .HasColumnName("cpf")
                .HasColumnType("varchar(14)");
            
            builder.HasKey(i => i.CPF);

            builder.HasMany(i => i.Emprestimo)
                .WithOne(p => p.Usuario)
                .HasForeignKey(i => i.UsuarioCpf);
        }
    }
}