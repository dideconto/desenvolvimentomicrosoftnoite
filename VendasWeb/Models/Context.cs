using Microsoft.EntityFrameworkCore;

namespace VendasWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
