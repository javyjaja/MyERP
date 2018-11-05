using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgregarCategoria()
        {
            var o = new ViewModelCategoria();
            o.caracteristicas = new List<Caracteristica>();
            

            return View(o);
        }

        public ActionResult VerCategorias()
        {
            return View();
        }
    }
}