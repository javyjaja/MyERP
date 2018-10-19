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
        //1.-ordenalas para su facil localizacion
        //2.-Comenta si una es nueva o actualizada

       
        public DbSet<Caracteristica> caracteristicas { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Categoria_Caracteristica> categorias_caracteriticas { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Producto_Caracteristica> productos_caracteristicas { get; set; }
        public DbSet<TipoDatos> tiposDatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
