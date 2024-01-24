using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        { 
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Proveedor> Proveedors { get; set;}
        public DbSet<Recibo> Reciboes { get; set;}

    }
}
