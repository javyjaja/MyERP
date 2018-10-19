using Dominio;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {
        private MProductos mProductos = new MProductos();
        private MCategorias mCategorias = new MCategorias();
        public ActionResult Index()
        {
            var cargaInicial = new CargaInicial();

            //var x = new Producto();
            //x.Nombre = "Casa";
            //mProductos.Add(x);
            return View(mProductos.Todos());
        }

        public ActionResult CrearProducto()
        {
            var listCategorias = new List<Categoria>();
            listCategorias.Add(new Categoria { Nombre = "categoria 1", Descripcion = "cat1", CategoriaId = 1 });
            listCategorias.Add(new Categoria { Nombre = "categoria 2", Descripcion = "cat2", CategoriaId = 2 });
            listCategorias.Add(new Categoria { Nombre = "categoria 3", Descripcion = "cat3", CategoriaId = 3 });
           
            ViewBag.LCategorias = listCategorias;
            ViewBag.CategoriaId = new SelectList(listCategorias, "CategoriaId", "Nombre");
            return View();
        }
        [HttpPost]
        public ActionResult CrearProducto(ViewModelProducto p)
        {


            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       [HttpPost]
        public virtual JsonResult CargaCaracteristicas(string CategoriaId)
        {

            return Json("Hola" + CategoriaId);
        }

    }
}