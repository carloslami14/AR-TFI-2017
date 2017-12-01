using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorProyectoWeb.Servicios;
using GestorProyectoWeb.Models;

namespace GestorProyectoWeb.Controllers
{
    public class RecursoHardwareController : Controller
    {
        private readonly Repositorio _repositorio;

        public RecursoHardwareController()
        {
            _repositorio = new Repositorio();
        }

        // GET: RecursoHardware
        public ActionResult Index()
        {
            var recursos = _repositorio.ObtenerRecursoHardware();
            return View(recursos);
        }

        // GET: RecursoHardware/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecursoHardware/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecursoHardware/Create
        [HttpPost]
        public ActionResult Create(RecursoHardware recurso)
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

        // GET: RecursoHardware/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecursoHardware/Edit/5
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

        // GET: RecursoHardware/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecursoHardware/Delete/5
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
