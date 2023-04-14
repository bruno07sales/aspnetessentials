using AplicativoWeb.Models;//Camada Model
using Microsoft.EntityFrameworkCore;//EF framework
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Fluent API
namespace AplicativoWeb.EntityConfigs; //Novo namespace

public class CursoEnityConfigs : IEntityTypeConfiguration<Curso>
{ //inicio
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");
        builder.HasKey(c=>c.Id);//Chave Primaria
        builder.Property (c=>c.TituloMarketing)
         .HasColumnType("Nvarch(80)")
         .IsRequired();

        builder.Property (c=>c.TituloInterno)
         .HasColumnType("Nvarch(80)")
         .IsRequired();



    }
} //fim