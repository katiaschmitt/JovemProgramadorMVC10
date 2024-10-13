using JovemProgramadorMVC10.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC10.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Email).HasColumnType("varchar(50)");
        }
    }
}
