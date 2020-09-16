using Microsoft.EntityFrameworkCore;

namespace BancoDadosConsole.Models
{
    class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=PessoasNoiteDb;Trusted_Connection=true");
        }
    }
}
