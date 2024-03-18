using Microsoft.EntityFrameworkCore;
using sqliteAPI.Models;

namespace sqliteAPI.DataContext
{
    public class ContatosContext : DbContext
    {
        public ContatosContext(DbContextOptions<ContatosContext> options) : base(options)
        {
            
        }
        public DbSet<Contato> contatos { get; set; }
    }
}
