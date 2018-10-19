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

            return View();
        }

        public ActionResult VerCategorias()
        {
            return View();
        }
    }
}