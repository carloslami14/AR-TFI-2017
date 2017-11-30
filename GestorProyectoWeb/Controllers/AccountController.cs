using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorProyectoWeb.Servicios;

namespace GestorProyectoWeb.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private Repositorio _repositorio;

        // GET: Account
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Iniciar( string usuario, string cont)
        {
            if (_repositorio.BuscarUsuario(usuario,cont))
            {
                return RedirectToRoute("Home/Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult List()
          {
            var usuarios = _repositorio.ObtenerUsuarios();
            return View();
          }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
