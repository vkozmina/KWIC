using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KWIC.Models;

namespace KWIC.Controllers
{
    public class URLsController : Controller
    {
        private vapidven_urlsEntities db = new vapidven_urlsEntities();

        // GET: URLs
        public ActionResult Index()
        {
            return View(db.URLs.ToList());
        }

        // GET: URLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            URL uRL = db.URLs.Find(id);
            if (uRL == null)
            {
                return HttpNotFound();
            }
            return View(uRL);
        }

        // GET: URLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: URLs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Description,URL1,id")] URL uRL)
        {
            if (ModelState.IsValid)
            {
                db.URLs.Add(uRL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uRL);
        }

        // GET: URLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            URL uRL = db.URLs.Find(id);
            if (uRL == null)
            {
                return HttpNotFound();
            }
            return View(uRL);
        }

        // POST: URLs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Description,URL1,id")] URL uRL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uRL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uRL);
        }

        // GET: URLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            URL uRL = db.URLs.Find(id);
            if (uRL == null)
            {
                return HttpNotFound();
            }
            return View(uRL);
        }

        // POST: URLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            URL uRL = db.URLs.Find(id);
            db.URLs.Remove(uRL);
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
