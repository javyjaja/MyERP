using Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Datos
{
    public class ERPContext : DbContext
    {
        public ERPContext() : base("strConn") {
            var ensureDLLIsCopied =
                  System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Producto> productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
