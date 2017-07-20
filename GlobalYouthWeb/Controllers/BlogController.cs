using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GlobalYouthWeb.Models;
using System.IO;

namespace GlobalYouthWeb.Controllers
{
    public class BlogController : Controller
    {
        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();

        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        // GET: Blog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

       


        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Author,Title,PostDate,Description,BlogContent,BlogImagePath")] Blog blog, HttpPostedFileBase fileOne)
        {
            var pathOne = "";
            if (ModelState.IsValid)
            {
                if (fileOne != null)
                {
                    if (fileOne.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileOne.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileOne.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileOne.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileOne.FileName).ToLower() == ".jpeg")
                        {
                            pathOne = Path.Combine(Server.MapPath("~/images"), fileOne.FileName);
                            fileOne.SaveAs(pathOne);
                            blog.BlogImagePath = fileOne.FileName;

                        }
                    }

                }
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Author,Title,PostDate,Description,BlogContent,BlogImagePath")] Blog blog, HttpPostedFileBase fileOne)
        {
            var pathOne = "";
            if (ModelState.IsValid)
            {
                if (fileOne != null)
                {
                    if (fileOne.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileOne.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileOne.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileOne.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileOne.FileName).ToLower() == ".jpeg")
                        {
                            pathOne = Path.Combine(Server.MapPath("~/images"), fileOne.FileName);
                            fileOne.SaveAs(pathOne);
                            blog.BlogImagePath = fileOne.FileName;

                        }
                    }

                }
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
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
