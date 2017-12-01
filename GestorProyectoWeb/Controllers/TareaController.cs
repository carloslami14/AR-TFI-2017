using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestorProyectoWeb.Servicios;
using GestorProyectoWeb.Models;

namespace GestorProyectoWeb.Controllers
{
    public class TareaController : Controller
    {
        private readonly Repositorio _repositorio;

        public TareaController()
        {
            _repositorio = new Repositorio();
        }


        // GET: Tarea
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tarea/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tarea/Create
        public ActionResult Create(int id)
        {
            var pro = new Proyecto { Id = id };
            ViewBag.Proyecto = pro;

            return View();
        }

        // POST: Tarea/Create
        [HttpPost]
        public ActionResult Create(Tarea tarea, int id)
        {
            try
            {
                // TODO: Add insert logic here
                var pro = new Proyecto { Id = id };
                ViewBag.Proyecto = pro;

                _repositorio.GuardarTarea(tarea, id);
                return RedirectToRoute(new
                {
                    controller = "Proyecto",
                    action = "Details",
                    id = id
                });
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarea/Edit/5
        public ActionResult Edit(int id)
        {
            var pro = new Proyecto { Id = id };
            ViewBag.Proyecto = pro;
            var tarea = _repositorio.BuscarTarea(id);
            return View(tarea);
        }

        // POST: Tarea/Edit/5
        [HttpPost]
        public ActionResult Edit(Tarea tarea,int id)
        {
            try
            {
                // TODO: Add update logic here

                var pro = new Proyecto { Id = id };
                ViewBag.Proyecto = pro;

                _repositorio.ModificarTarea(tarea);
                return RedirectToRoute(new
                {
                    controller = "Proyecto",
                    action = "Details",
                    id = id
                });
            }
            catch
            {
                return View();
            }
        }

        // GET: Tarea/Delete/5
        public ActionResult Delete(int id)
        {
           
            var tarea = _repositorio.BuscarTarea(id);

            ViewBag.id = tarea.ProyectoId;
           
            return View(tarea);
        }

        // POST: Tarea/Delete/5
        [HttpPost]
        public ActionResult Delete(Tarea tarea, int id)
        {
            try
            {
                // TODO: Add delete logic here

                _repositorio.EliminarTarea(tarea.IdTarea);
                return RedirectToRoute(new
                {
                    controller = "Proyecto",
                    action = "Details",
                    id = id
                });

            }
            catch
            {
                return View();
            }
        }
    }
}
