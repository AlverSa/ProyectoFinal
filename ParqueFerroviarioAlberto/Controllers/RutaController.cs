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
    public class RutaController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Ruta
        public ActionResult Index()
        {
            return View(db.ruta.ToList());
        }

        // GET: Ruta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // GET: Ruta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ruta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRuta,rutaTren,estatus,idCiudad")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.ruta.Add(ruta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ruta);
        }

        // GET: Ruta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // POST: Ruta/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRuta,rutaTren,estatus,idCiudad")] Ruta ruta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ruta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ruta);
        }

        // GET: Ruta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruta ruta = db.ruta.Find(id);
            if (ruta == null)
            {
                return HttpNotFound();
            }
            return View(ruta);
        }

        // POST: Ruta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ruta ruta = db.ruta.Find(id);
            db.ruta.Remove(ruta);
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
