using Microsoft.EntityFrameworkCore;
using MoneyMap.Api.Models;

namespace MoneyMap.Api.Data
{
    public class MoneyMapContext : DbContext
    {
        public MoneyMapContext(DbContextOptions<MoneyMapContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}