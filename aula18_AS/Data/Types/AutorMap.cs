using aula18_AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula18_AS.Data.Types
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autor");

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .IsRequired();

            builder.Property(i => i.CPF)
                .HasColumnName("cpf")
                .IsRequired()
                .HasColumnType("varchar(14)");
            
            builder.HasKey(i => i.CPF);

            builder.HasMany(i => i.LivrosAutores)
                .WithOne(p => p.Autores)
                .HasForeignKey(p => p.AutorCpf);
        }
    }
}