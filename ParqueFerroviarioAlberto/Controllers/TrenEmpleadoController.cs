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
    public class TrenEmpleadoController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: TrenEmpleado
        public ActionResult Index()
        {
            return View(db.trenempleado.ToList());
        }

        // GET: TrenEmpleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrenEmpleado trenEmpleado = db.trenempleado.Find(id);
            if (trenEmpleado == null)
            {
                return HttpNotFound();
            }
            return View(trenEmpleado);
        }

        // GET: TrenEmpleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrenEmpleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTrenEmpleado,idTren,idEmpleado,estatus")] TrenEmpleado trenEmpleado)
        {
            if (ModelState.IsValid)
            {
                db.trenempleado.Add(trenEmpleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trenEmpleado);
        }

        // GET: TrenEmpleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrenEmpleado trenEmpleado = db.trenempleado.Find(id);
            if (trenEmpleado == null)
            {
                return HttpNotFound();
            }
            return View(trenEmpleado);
        }

        // POST: TrenEmpleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTrenEmpleado,idTren,idEmpleado,estatus")] TrenEmpleado trenEmpleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trenEmpleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trenEmpleado);
        }

        // GET: TrenEmpleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrenEmpleado trenEmpleado = db.trenempleado.Find(id);
            if (trenEmpleado == null)
            {
                return HttpNotFound();
            }
            return View(trenEmpleado);
        }

        // POST: TrenEmpleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrenEmpleado trenEmpleado = db.trenempleado.Find(id);
            db.trenempleado.Remove(trenEmpleado);
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
