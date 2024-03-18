using Microsoft.EntityFrameworkCore;
using sqlserverAPI.Models;

namespace sqlserverAPI.DataContext
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
