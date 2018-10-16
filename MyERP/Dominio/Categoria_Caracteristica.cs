using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria_Caracteristica
    {
        [Key]
        public int Categoria_CaracteristicaId { get; set; }

        public int CategoriaId { get; set; }

        public int CaracteristicaId { get; set; }
    }
}
