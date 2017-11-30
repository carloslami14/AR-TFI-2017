using GestorProyectoWeb.Models;
using GestorProyectoWeb.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorProyectoWeb.Controllers
{
    public class ProyectoController : Controller
    {
        private Repositorio _repositorio;
        
        
        public ProyectoController()
        {
            _repositorio = new Repositorio();
        }

        // GET: Proyecto
        public ActionResult Index()
        {
            var proyectos = _repositorio.ObtenerProyectos();
            return View(proyectos);
        }

        // GET: Proyecto/Details/5
        public ActionResult Details(int id)
        {
            var proyecto = _repositorio.BuscarProyecto(id);
            return View(proyecto);
        }

        // GET: Proyecto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyecto/Create
        [HttpPost]
        public ActionResult Create(Proyecto proyecto)
        {
            try
            {
                   _repositorio.GuardarProyecto(proyecto);
            }
            catch (Exception ex)
            {

                return View();
            }

            return RedirectToAction("Index");
        }

        // GET: Proyecto/Edit/5
        public ActionResult Edit(int id)
        {
            Proyecto p = _repositorio.BuscarProyecto(id);
            return View(p);
        }

        // POST: Proyecto/Edit/5
        [HttpPost]
        public ActionResult Edit(Proyecto p)
        {
            try
            {
                // TODO: Add update logic here
                _repositorio.ModificarProyecto(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proyecto/Delete/5
        public ActionResult Delete(int id)
        {
            var proyecto = _repositorio.BuscarProyecto(id);
            return View(proyecto);
        }

        // POST: Proyecto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _repositorio.EliminarProyecto(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
