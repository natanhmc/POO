using aula18_AS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula18_AS.Data.Types
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro");

            builder.Property(i => i.Id)
                .HasColumnName("id");
                
            builder.Property(i => i.Titulo)
                .HasColumnName("titulo")
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(i => i.NumeroPag)
                .HasColumnName("numero_pag")
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(i => i.CodBarras)
                .HasColumnName("cod_barras")
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasKey(i => i.CodBarras);

            builder.HasMany(i => i.LivrosAutores)
                .WithOne(p => p.Livros)
                .HasForeignKey(p => p.LivroCodBarras);
            
            builder.HasMany(i => i.Emprestimos)
                .WithOne(e => e.Livro)
                .HasForeignKey(p => p.LivroCodBarras);
        }
    }
}