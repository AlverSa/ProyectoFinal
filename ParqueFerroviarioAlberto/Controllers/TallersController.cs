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
    public class TallersController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Tallers
        public ActionResult Index()
        {
            return View(db.taller.ToList());
        }

        // GET: Tallers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taller taller = db.taller.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // GET: Tallers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tallers/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTaller,ubicacion,estatus")] Taller taller)
        {
            if (ModelState.IsValid)
            {
                db.taller.Add(taller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taller);
        }

        // GET: Tallers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taller taller = db.taller.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // POST: Tallers/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTaller,ubicacion,estatus")] Taller taller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taller);
        }

        // GET: Tallers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taller taller = db.taller.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // POST: Tallers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Taller taller = db.taller.Find(id);
            db.taller.Remove(taller);
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
