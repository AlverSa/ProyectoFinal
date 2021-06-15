using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParqueFerroviarioAlberto.Models;

namespace ParqueFerroviarioAlberto.Controllers
{
    public class EstacionController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Estacion
        public ActionResult Index()
        {
            return View(db.estacion.ToList());
        }

        // GET: Estacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacion estacion = db.estacion.Find(id);
            if (estacion == null)
            {
                return HttpNotFound();
            }
            return View(estacion);
        }

        // GET: Estacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEstacion,salida,llegada,telefono,estatus,idEmpresa")] Estacion estacion)
        {
            if (ModelState.IsValid)
            {
                db.estacion.Add(estacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estacion);
        }

        // GET: Estacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacion estacion = db.estacion.Find(id);
            if (estacion == null)
            {
                return HttpNotFound();
            }
            return View(estacion);
        }

        // POST: Estacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEstacion,salida,llegada,telefono,estatus,idEmpresa")] Estacion estacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estacion);
        }

        // GET: Estacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacion estacion = db.estacion.Find(id);
            if (estacion == null)
            {
                return HttpNotFound();
            }
            return View(estacion);
        }

        // POST: Estacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estacion estacion = db.estacion.Find(id);
            db.estacion.Remove(estacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
