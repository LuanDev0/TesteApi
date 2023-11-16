using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models.Teste01;

namespace TESTE.Dados
{
    public class AppDataContexto : DbContext
    {
        public int MyProperty { get; set; }

        public DbSet<Teste01> teste1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=MinhaBaseDeDados.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}