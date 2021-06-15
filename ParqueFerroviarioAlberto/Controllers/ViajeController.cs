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
    public class ViajeController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Viaje
        public ActionResult Index()
        {
            return View(db.viaje.ToList());
        }

        // GET: Viaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.viaje.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            return View(viaje);
        }

        // GET: Viaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Viaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idViaje,origen,destino,estatus,idTren")] Viaje viaje)
        {
            if (ModelState.IsValid)
            {
                db.viaje.Add(viaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viaje);
        }

        // GET: Viaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.viaje.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            return View(viaje);
        }

        // POST: Viaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idViaje,origen,destino,estatus,idTren")] Viaje viaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viaje);
        }

        // GET: Viaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viaje viaje = db.viaje.Find(id);
            if (viaje == null)
            {
                return HttpNotFound();
            }
            return View(viaje);
        }

        // POST: Viaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viaje viaje = db.viaje.Find(id);
            db.viaje.Remove(viaje);
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
