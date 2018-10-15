using ModuloInventario;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Datos
{
    public class Context : DbContext
    {
        public Context() : base("strConn") { }
        public DbSet<Productos> productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
