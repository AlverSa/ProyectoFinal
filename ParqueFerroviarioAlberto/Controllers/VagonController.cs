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
    public class VagonController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: Vagon
        public ActionResult Index()
        {
            return View(db.vagon.ToList());
        }

        // GET: Vagon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vagon vagon = db.vagon.Find(id);
            if (vagon == null)
            {
                return HttpNotFound();
            }
            return View(vagon);
        }

        // GET: Vagon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vagon/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idVagon,carga,estatus,idPatio,idTaller,idTren")] Vagon vagon)
        {
            if (ModelState.IsValid)
            {
                db.vagon.Add(vagon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vagon);
        }

        // GET: Vagon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vagon vagon = db.vagon.Find(id);
            if (vagon == null)
            {
                return HttpNotFound();
            }
            return View(vagon);
        }

        // POST: Vagon/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idVagon,carga,estatus,idPatio,idTaller,idTren")] Vagon vagon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vagon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vagon);
        }

        // GET: Vagon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vagon vagon = db.vagon.Find(id);
            if (vagon == null)
            {
                return HttpNotFound();
            }
            return View(vagon);
        }

        // POST: Vagon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vagon vagon = db.vagon.Find(id);
            db.vagon.Remove(vagon);
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
