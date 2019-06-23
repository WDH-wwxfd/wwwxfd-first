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
    public class TeacherController : Controller
    {
        private CourseManageEntities db = new CourseManageEntities();

        //
        // GET: /Teachers/

        public ActionResult Index()
        {
            return View(db.Teachers.ToList());
        }

        //
        // GET: /Teachers/Details/5

        public ActionResult Details(int id = 0)
        {
            Teachers Teachers = db.Teachers.Find(id);
            if (Teachers == null)
            {
                return HttpNotFound();
            }
            return View(Teachers);
        }

        //
        // GET: /Teachers/Create

        public ActionResult Create()
        {
            var classes = db.Classes.ToList();
            ViewBag.Classes = classes;
            var teachers = db.Teachers.ToList();
            ViewBag.Teachers = teachers;
            var course = db.Course.ToList();
            ViewBag.Ccourse = course;
            return View();
        }

        //
        // POST: /Teachers/Create

        [HttpPost]
        public ActionResult Create(Teachers Teachers)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(Teachers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Teachers);
        }

        //
        // GET: /Teachers/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Teachers Teachers = db.Teachers.Find(id);
            if (Teachers == null)
            {
                return HttpNotFound();
            }
            return View(Teachers);
        }

        //
        // POST: /Teachers/Edit/5

        [HttpPost]
        public ActionResult Edit(Teachers Teachers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Teachers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Teachers);
        }

        //
        // GET: /Teachers/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Teachers Teachers = db.Teachers.Find(id);
            if (Teachers == null)
            {
                return HttpNotFound();
            }
            return View(Teachers);
        }

        //
        // POST: /Teachers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Teachers Teachers = db.Teachers.Find(id);
            db.Teachers.Remove(Teachers);
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