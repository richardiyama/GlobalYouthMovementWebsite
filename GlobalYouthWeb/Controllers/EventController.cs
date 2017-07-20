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
    public class EventController : Controller
    {
        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();

        // GET: Event
        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,titleOne,bodyOne,ImagePath,titleTwo,bodyTwo,Date,bodyThree,bodyFour,bodyFive,bodySix")] Event @event, HttpPostedFileBase fileOne)
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
                            pathOne = Path.Combine(Server.MapPath("~/images"),fileOne.FileName);
                            fileOne.SaveAs(pathOne);
                            @event.ImagePath = fileOne.FileName;

                        }
                    }

                }

                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,titleOne,bodyOne,ImagePath,titleTwo,bodyTwo,Date,bodyThree,bodyFour,bodyFive,bodySix")] Event @event, HttpPostedFileBase fileOne)
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
                            @event.ImagePath = fileOne.FileName;

                        }
                    }

                }
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
