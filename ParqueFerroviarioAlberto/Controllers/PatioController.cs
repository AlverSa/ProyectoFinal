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
    public class PatioController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Patio
        public ActionResult Index()
        {
            return View(db.patio.ToList());
        }

        // GET: Patio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patio patio = db.patio.Find(id);
            if (patio == null)
            {
                return HttpNotFound();
            }
            return View(patio);
        }

        // GET: Patio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPatio,ubicacion,estatus,idCiudad")] Patio patio)
        {
            if (ModelState.IsValid)
            {
                db.patio.Add(patio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patio);
        }

        // GET: Patio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patio patio = db.patio.Find(id);
            if (patio == null)
            {
                return HttpNotFound();
            }
            return View(patio);
        }

        // POST: Patio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPatio,ubicacion,estatus,idCiudad")] Patio patio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patio);
        }

        // GET: Patio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patio patio = db.patio.Find(id);
            if (patio == null)
            {
                return HttpNotFound();
            }
            return View(patio);
        }

        // POST: Patio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patio patio = db.patio.Find(id);
            db.patio.Remove(patio);
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
