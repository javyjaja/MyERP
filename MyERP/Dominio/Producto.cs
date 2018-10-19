using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
     

    }
}
