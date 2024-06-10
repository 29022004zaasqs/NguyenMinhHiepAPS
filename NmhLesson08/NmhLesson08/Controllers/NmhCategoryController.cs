using NmhLesson08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NmhLesson08.Controllers
{
    public class NmhCategoryController : Controller
    {
        private static NmhBookStore _NmhBookStore;
        public NmhCategoryController()
        {
            _NmhBookStore = new NmhBookStore();
        }
        // GET: NmhCategory
        public ActionResult NmhIndex()
        {
            var nmhCategory = _NmhBookStore.NmhCategories.ToList();
            return View(nmhCategory);
        }

        [HttpGet]
        public ActionResult NmhCreate()
        {
            var nmhCategory = new NmhCategory();
            return View(nmhCategory);
        }
        [HttpPost]
        public ActionResult NmhCreate(NmhCategory nmhCategory)
        {
            _NmhBookStore.NmhCategories.Add(nmhCategory);
            _NmhBookStore.SaveChanges();
            return RedirectToAction("NmhIndex");
        }
    }
}