using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ViewModelProducto
    {
        public Producto producto { get; set; }
        public int CategoriaId { get; set; }
        public List<Caracteristica> Caracteristicas { get; set; }
    }
}
