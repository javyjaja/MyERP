using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CargaInicial
    {
       public CargaInicial()
        {
            var DB = new ERPContext();

          
            if ( DB.tiposDatos.Count() == 0)// Si no hay tipo de datos no hay nada
            {
                //Cargamos los Tipos de datos
                DB.tiposDatos.Add(new TipoDatos { Nombre = "Entero", Descripcion = "Entero Normal" });
                DB.tiposDatos.Add(new TipoDatos { Nombre = "Cadena", Descripcion = "string Normal" });
                DB.tiposDatos.Add(new TipoDatos { Nombre = "Boleano", Descripcion = "Boleano Normal" });
                DB.SaveChanges();
            }
            

        }
    }
}
