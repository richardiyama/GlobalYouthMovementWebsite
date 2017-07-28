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
    public class AboutController : Controller
    {
        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();

        // GET: About
        public ActionResult Index()
        {
            return View(db.Abouts.ToList());
        }

        
        // GET: About/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            About about = db.Abouts.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }
            return View(about);
        }

        // GET: About/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ImagePathOne,SubTitle,BodyOne,BodyTwo,TitleTwo,BodyThree,TitleThree,BodyFour,TitleFour,BodyFive,TitleFive,BodySix,ImagePathTwo")] About about, HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo)
        {

            var pathOne = "";

            var pathTwo = "";


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
                            about.ImagePathOne = fileOne.FileName;

                        }
                    }

                }

                if (fileTwo != null)
                {
                    if (fileTwo.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTwo.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".jpeg")
                        {
                            pathTwo = Path.Combine(Server.MapPath("~/images"), fileTwo.FileName);
                            fileOne.SaveAs(pathTwo);
                            about.ImagePathTwo = fileTwo.FileName;

                        }
                    }

                }
                if (about.ID == 1)
                {
                    db.Abouts.Add(about);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(about);
        }

        // GET: About/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            About about = db.Abouts.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }
            return View(about);
        }

        // POST: About/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ImagePathOne,SubTitle,BodyOne,BodyTwo,TitleTwo,BodyThree,TitleThree,BodyFour,TitleFour,BodyFive,TitleFive,BodySix,ImagePathTwo")] About about, HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo)
        {
            var pathOne = "";

            var pathTwo = "";


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
                            about.ImagePathOne = fileOne.FileName;

                        }
                    }

                }

                if (fileTwo != null)
                {
                    if (fileTwo.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTwo.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTwo.FileName).ToLower() == ".jpeg")
                        {
                            pathTwo = Path.Combine(Server.MapPath("~/images"), fileTwo.FileName);
                            fileOne.SaveAs(pathTwo);
                            about.ImagePathTwo = fileTwo.FileName;

                        }
                    }

                }
                db.Entry(about).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }

        // GET: About/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            About about = db.Abouts.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }
            return View(about);
        }

        // POST: About/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            About about = db.Abouts.Find(id);
            db.Abouts.Remove(about);
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
