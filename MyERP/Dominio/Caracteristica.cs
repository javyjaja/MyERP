using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Caracteristica
    {
        [Key]
        public int CaracteristicaId { get; set; }

        //public int ProductoId { get; set; }

        public string Nombre { get; set; }

        public int TipoDatoId { get; set; }
    }
}
