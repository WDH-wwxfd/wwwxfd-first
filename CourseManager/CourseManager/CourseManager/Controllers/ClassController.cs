using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManage.Models;

namespace CourseManage.Controllers
{
    public class ClassController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        //
        // GET: /Class/

        public ActionResult Index()
        {
            return View(db.Classes.ToList());
        }

        //
        // GET: /Class/Details/5

        public ActionResult Details(int id = 0)
        {
            Classes Classes = db.Classes.Find(id);
            if (Classes == null)
            {
                return HttpNotFound();
            }
            return View(Classes);
        }

        //
        // GET: /Class/Create

        public ActionResult Create()
        {

            var Teacher = db.Teachers.ToList();
            ViewBag.Teacher = Teacher;
            return View();
        }

        //
        // POST: /Class/Create

        [HttpPost]
        public ActionResult Create(Classes Classes)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Add(Classes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Classes);
        }

        //
        // GET: /Class/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Classes Classes = db.Classes.Find(id);
            if (Classes == null)
            {
                return HttpNotFound();
            }
            return View(Classes);
        }

        //
        // POST: /Class/Edit/5

        [HttpPost]
        public ActionResult Edit(Classes Classes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Classes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Classes);
        }

        //
        // GET: /Class/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Classes Classes = db.Classes.Find(id);
            if (Classes == null)
            {
                return HttpNotFound();
            }
            return View(Classes);
        }

        //
        // POST: /Class/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Classes Classes = db.Classes.Find(id);
            db.Classes.Remove(Classes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}