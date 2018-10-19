using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ViewModelCategoria
    {
        public Categoria categoria { get; set; }

        public List<Caracteristica> caracteristicas { get; set; }
    }
}
