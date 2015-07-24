using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcentity.Models;

namespace mvcentity.Controllers
{
    public class BuchhaltungController : Controller
    {
        private Buchhaltung db = new Buchhaltung();

        // GET: Buchhaltung
        public ActionResult Index()
        {
            return View(db.Transaktionen.ToList());
        }

        // GET: Buchhaltung/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaktion transaktion = db.Transaktionen.Find(id);
            if (transaktion == null)
            {
                return HttpNotFound();
            }
            return View(transaktion);
        }

        // GET: Buchhaltung/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buchhaltung/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Summe,Datum,IstAusgabe,Information")] Transaktion transaktion)
        {
            if (ModelState.IsValid)
            {
                db.Transaktionen.Add(transaktion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transaktion);
        }

        // GET: Buchhaltung/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaktion transaktion = db.Transaktionen.Find(id);
            if (transaktion == null)
            {
                return HttpNotFound();
            }
            return View(transaktion);
        }

        // POST: Buchhaltung/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Summe,Datum,IstAusgabe,Information")] Transaktion transaktion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaktion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transaktion);
        }

        // GET: Buchhaltung/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaktion transaktion = db.Transaktionen.Find(id);
            if (transaktion == null)
            {
                return HttpNotFound();
            }
            return View(transaktion);
        }

        // POST: Buchhaltung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaktion transaktion = db.Transaktionen.Find(id);
            db.Transaktionen.Remove(transaktion);
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
