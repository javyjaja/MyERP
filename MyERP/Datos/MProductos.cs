using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MProductos
    {
        private ERPContext DB = new ERPContext();
        public List<Producto> Todos()
        {
            var x = DB.productos;
            var y = x.ToList();
            var z = x.Where(mx => mx.Nombre == "").ToList();
            return DB.productos.ToList();
        }
        public void Add(Producto p)
        {
            DB.productos.Add(p);
            DB.SaveChanges();
            var x = 2;
        }

        public void CrearProducto(ViewModelProducto p)
        {

        }

    }
}
