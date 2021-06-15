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
    public class CompraArticuloController : Controller
    {
        private ParqueFerroviario db = new ParqueFerroviario();

        // GET: CompraArticulo
        public ActionResult Index()
        {
            return View(db.compraarticulo.ToList());
        }

        // GET: CompraArticulo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraArticulo compraArticulo = db.compraarticulo.Find(id);
            if (compraArticulo == null)
            {
                return HttpNotFound();
            }
            return View(compraArticulo);
        }

        // GET: CompraArticulo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompraArticulo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCompraArticulo,idCompra,idArticulo,estatus")] CompraArticulo compraArticulo)
        {
            if (ModelState.IsValid)
            {
                db.compraarticulo.Add(compraArticulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compraArticulo);
        }

        // GET: CompraArticulo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraArticulo compraArticulo = db.compraarticulo.Find(id);
            if (compraArticulo == null)
            {
                return HttpNotFound();
            }
            return View(compraArticulo);
        }

        // POST: CompraArticulo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCompraArticulo,idCompra,idArticulo,estatus")] CompraArticulo compraArticulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compraArticulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compraArticulo);
        }

        // GET: CompraArticulo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraArticulo compraArticulo = db.compraarticulo.Find(id);
            if (compraArticulo == null)
            {
                return HttpNotFound();
            }
            return View(compraArticulo);
        }

        // POST: CompraArticulo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompraArticulo compraArticulo = db.compraarticulo.Find(id);
            db.compraarticulo.Remove(compraArticulo);
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
