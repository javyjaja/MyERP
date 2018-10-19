using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MCategorias
    {
        private ERPContext db = new ERPContext();

        public List<Categoria> Todas()
        {
            return db.categorias.ToList();
        }
    }
}
