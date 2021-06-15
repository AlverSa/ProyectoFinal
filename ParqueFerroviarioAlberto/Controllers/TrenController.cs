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
    public class TrenController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Tren
        public ActionResult Index()
        {
            return View(db.tren.ToList());
        }

        // GET: Tren/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tren tren = db.tren.Find(id);
            if (tren == null)
            {
                return HttpNotFound();
            }
            return View(tren);
        }

        // GET: Tren/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tren/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTren,numero,destino,diesel,fabricado,estatus,idEstacion")] Tren tren)
        {
            if (ModelState.IsValid)
            {
                db.tren.Add(tren);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tren);
        }

        // GET: Tren/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tren tren = db.tren.Find(id);
            if (tren == null)
            {
                return HttpNotFound();
            }
            return View(tren);
        }

        // POST: Tren/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTren,numero,destino,diesel,fabricado,estatus,idEstacion")] Tren tren)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tren).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tren);
        }

        // GET: Tren/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tren tren = db.tren.Find(id);
            if (tren == null)
            {
                return HttpNotFound();
            }
            return View(tren);
        }

        // POST: Tren/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tren tren = db.tren.Find(id);
            db.tren.Remove(tren);
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
