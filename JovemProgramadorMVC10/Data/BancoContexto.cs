using JovemProgramadorMVC10.Data.Mapeamento;
using JovemProgramadorMVC10.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC10.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }
    }
}
