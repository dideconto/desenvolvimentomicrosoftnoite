using Microsoft.EntityFrameworkCore;

namespace VendasWPF.Models
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=VendasWPFNoite;Trusted_Connection=true");
        }
    }
}
