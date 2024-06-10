using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NmhLesson08.Models;

namespace NmhLesson08.Controllers
{
    public class NmhBooksController : Controller
    {
        private NmhBookStore db = new NmhBookStore();

        // GET: NmhBooks
        public ActionResult Index()
        {
            var nmhBooks = db.NmhBooks.Include(n => n.NmhCategory);
            return View(nmhBooks.ToList());
        }

        // GET: NmhBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhBook nmhBook = db.NmhBooks.Find(id);
            if (nmhBook == null)
            {
                return HttpNotFound();
            }
            return View(nmhBook);
        }

        // GET: NmhBooks/Create
        public ActionResult Create()
        {
            ViewBag.NmhCategoryId = new SelectList(db.NmhCategories, "NmhCategoryId", "NmhCategoryName");
            return View();
        }

        // POST: NmhBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NmhBookId,NmhTitle,NmhAuthor,NmhYear,NmhPublisher,NmhPicture,NmhCategoryId")] NmhBook nmhBook)
        {
            if (ModelState.IsValid)
            {
                db.NmhBooks.Add(nmhBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NmhCategoryId = new SelectList(db.NmhCategories, "NmhCategoryId", "NmhCategoryName", nmhBook.NmhCategoryId);
            return View(nmhBook);
        }

        // GET: NmhBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhBook nmhBook = db.NmhBooks.Find(id);
            if (nmhBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.NmhCategoryId = new SelectList(db.NmhCategories, "NmhCategoryId", "NmhCategoryName", nmhBook.NmhCategoryId);
            return View(nmhBook);
        }

        // POST: NmhBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NmhBookId,NmhTitle,NmhAuthor,NmhYear,NmhPublisher,NmhPicture,NmhCategoryId")] NmhBook nmhBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nmhBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NmhCategoryId = new SelectList(db.NmhCategories, "NmhCategoryId", "NmhCategoryName", nmhBook.NmhCategoryId);
            return View(nmhBook);
        }

        // GET: NmhBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NmhBook nmhBook = db.NmhBooks.Find(id);
            if (nmhBook == null)
            {
                return HttpNotFound();
            }
            return View(nmhBook);
        }

        // POST: NmhBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NmhBook nmhBook = db.NmhBooks.Find(id);
            db.NmhBooks.Remove(nmhBook);
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
