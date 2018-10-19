using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto_Caracteristica
    {
        public int Producto_CaracteristicaID { get; set; }

        public int ProductoId { get; set; }

        public int CaracteristicaId { get; set; }

        public string Valor { get; set; }
    }
}
