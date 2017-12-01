using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorProyectoWeb.Servicios;
using GestorProyectoWeb.Models;

namespace GestorProyectoWeb.Controllers
{
    public class RecursoSoftwareController : Controller
    {
        private readonly Repositorio _repositorio;
        
        public RecursoSoftwareController()
        {
            _repositorio = new Repositorio();
        }

        // GET: Recurso
        public ActionResult Index()
        {
            var recurso = _repositorio.ObtenerRecursosSoftware();
            return View(recurso);
        }

        // GET: Recurso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recurso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recurso/Create
        [HttpPost]
        public ActionResult Create(RecursoSoftware recurso)
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

        // GET: Recurso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recurso/Edit/5
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

        // GET: Recurso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recurso/Delete/5
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
