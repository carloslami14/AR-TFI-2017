using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorProyectoWeb.Servicios;
using GestorProyectoWeb.Models;

namespace GestorProyectoWeb.Controllers
{
    public class RecursoHumanoController : Controller
    {
        private readonly Repositorio _repositorio;

        public RecursoHumanoController()
        {
            _repositorio = new Repositorio();
        }

        // GET: RecursoHumano
        public ActionResult Index()
        {
            var recursos = _repositorio.ObtenerRecursosHumano();
            return View(recursos);
        }

        // GET: RecursoHumano/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecursoHumano/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecursoHumano/Create
        [HttpPost]
        public ActionResult Create(RecursoHumano recurso)
        {
            try
            {
                // TODO: Add insert logic here
                _repositorio.GuardarRecurso(recurso);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RecursoHumano/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecursoHumano/Edit/5
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

        // GET: RecursoHumano/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecursoHumano/Delete/5
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
