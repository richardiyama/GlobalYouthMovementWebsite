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
    public class IndexController : Controller
    {
        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();

       
       // GET: Index
        public ActionResult Index()
        {
            return View(db.Indices.ToList());
        }

        // GET: Index/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // GET: Index/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Index/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,bannerTitleOne,bannerBodyOne,bannerTitleTwo,bannerBodyTwo,bannerTitleThree,bannerBodyThree,welcomeTitle,welcomeSubTitle,welcomeBody,welcomeContentTitleOne,welcomeContentOne,welcomeContentTitleTwo,welcomeContentTwo,welcomeContentTitleThree,welcomeContentThree,welcomeContentTitleFour,welcomeContentFour,eventTitle,eventBody,eventImagePathOne,eventContentTitleOne,eventContentOne,eventDate,eventImagePathTwo,eventTitleTwo,eventImagePathThree,eventTitleThree,eventImagePathFour,eventTitleFour,eventImagePathFive,eventTitleFive,helpImagePath,helpTitle,helpSubTitle,helpContent,teamTitle,teamImagePathOne,teamNameOne,teamNameContentOne,teamTextNameOne,teamTextContentOne,teamImagePathTwo,teamNameTwo,teamNameContentTwo,teamTextNameTwo,teamTextContentTwo,teamImagePathThree,teamNameThree,teamNameContentThree,teamTextNameThree,teamTextContentThree,teamImagePathFour,teamNameFour,teamNameContentFour,teamTextNameFour,teamTextContentFour,companyName,addressContent,mobileOne,mobileTwo,companyEmail")] Index index, HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo, HttpPostedFileBase fileThree,

HttpPostedFileBase fileFour, HttpPostedFileBase fileFive, HttpPostedFileBase fileSix, HttpPostedFileBase fileSeven, HttpPostedFileBase fileEight,

HttpPostedFileBase fileNine, HttpPostedFileBase fileTen)
        {
            var pathOne = "";
            var pathTwo = "";
            var pathThree = "";
            var pathFour = "";
            var pathFive = "";

            var pathSix = "";
            var pathSeven = "";
            var pathEight = "";
            var pathNine = "";
            var pathTen = "";
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
                            index.eventImagePathOne = fileOne.FileName;

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
                            pathTwo = Path.Combine(Server.MapPath("~/images"),fileTwo.FileName);
                            fileTwo.SaveAs(pathTwo);
                            index.eventImagePathTwo = fileTwo.FileName;
                        }
                    }
                }
                if (fileThree != null)
                {
                    if (fileThree.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileThree.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileThree.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileThree.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileThree.FileName).ToLower() == ".jpeg")
                        {
                            pathThree = Path.Combine(Server.MapPath("~/images"),fileThree.FileName);
                            fileThree.SaveAs(pathThree);
                            index.eventImagePathThree = fileThree.FileName;
                        }
                    }
                }
                if (fileFour != null)
                {
                    if (fileFour.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFour.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFour.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFour.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFour.FileName).ToLower() == ".jpeg")
                        {
                            pathFour = Path.Combine(Server.MapPath("~/images"),fileFour.FileName);
                            fileFour.SaveAs(pathFour);
                            index.eventImagePathFour = fileFour.FileName;
                        }
                    }
                }

                if (fileFive != null)
                {
                    if (fileFive.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFive.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFive.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFive.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFive.FileName).ToLower() == ".jpeg")
                        {
                            pathFive = Path.Combine(Server.MapPath("~/images"), fileFive.FileName);
                            fileFive.SaveAs(pathFive);
                            index.eventImagePathFive = fileFive.FileName;
                        }
                    }
                }

                if (fileSix != null)
                {
                    if (fileSix.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSix.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSix.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSix.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSix.FileName).ToLower() == ".jpeg")
                        {
                            pathSix = Path.Combine(Server.MapPath("~/images"),fileSix.FileName);
                            fileSix.SaveAs(pathSix);
                            index.teamImagePathOne = fileOne.FileName;

                        }
                    }

                }


                if (fileSeven != null)
                {
                    if (fileSeven.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSeven.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".jpeg")
                        {
                            pathSeven = Path.Combine(Server.MapPath("~/images"),fileSeven.FileName);
                            fileSeven.SaveAs(pathSeven);
                            index.teamImagePathTwo = fileSeven.FileName;
                        }
                    }
                }
                if (fileEight != null)
                {
                    if (fileEight.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEight.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEight.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEight.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEight.FileName).ToLower() == ".jpeg")
                        {
                            pathEight = Path.Combine(Server.MapPath("~/images"),fileEight.FileName);
                            fileEight.SaveAs(pathEight);
                            index.teamImagePathThree = fileEight.FileName;
                        }
                    }
                }
                if (fileNine != null)
                {
                    if (fileNine.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileNine.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileNine.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileNine.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileNine.FileName).ToLower() == ".jpeg")
                        {
                            pathNine = Path.Combine(Server.MapPath("~/images"),fileNine.FileName);
                            fileNine.SaveAs(pathNine);
                            index.teamImagePathFour = fileFour.FileName;
                        }
                    }
                }

                if (fileTen != null)
                {
                    if (fileTen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTen.FileName).ToLower() == ".jpeg")
                        {
                            pathTen = Path.Combine(Server.MapPath("~/images"), fileTen.FileName);
                            fileTen.SaveAs(pathTen);
                            index.helpImagePath = fileTen.FileName;
                        }
                    }
                }
                db.Indices.Add(index);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(index);
        }

        // GET: Index/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // POST: Index/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,bannerTitleOne,bannerBodyOne,bannerTitleTwo,bannerBodyTwo,bannerTitleThree,bannerBodyThree,welcomeTitle,welcomeSubTitle,welcomeBody,welcomeContentTitleOne,welcomeContentOne,welcomeContentTitleTwo,welcomeContentTwo,welcomeContentTitleThree,welcomeContentThree,welcomeContentTitleFour,welcomeContentFour,eventTitle,eventBody,eventImagePathOne,eventContentTitleOne,eventContentOne,eventDate,eventImagePathTwo,eventTitleTwo,eventImagePathThree,eventTitleThree,eventImagePathFour,eventTitleFour,eventImagePathFive,eventTitleFive,helpImagePath,helpTitle,helpSubTitle,helpContent,teamTitle,teamImagePathOne,teamNameOne,teamNameContentOne,teamTextNameOne,teamTextContentOne,teamImagePathTwo,teamNameTwo,teamNameContentTwo,teamTextNameTwo,teamTextContentTwo,teamImagePathThree,teamNameThree,teamNameContentThree,teamTextNameThree,teamTextContentThree,teamImagePathFour,teamNameFour,teamNameContentFour,teamTextNameFour,teamTextContentFour,companyName,addressContent,mobileOne,mobileTwo,companyEmail")] Index index, HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo, HttpPostedFileBase fileThree,

HttpPostedFileBase fileFour, HttpPostedFileBase fileFive, HttpPostedFileBase fileSix, HttpPostedFileBase fileSeven, HttpPostedFileBase fileEight,

HttpPostedFileBase fileNine, HttpPostedFileBase fileTen)
        {
            var pathOne = "";
            var pathTwo = "";
            var pathThree = "";
            var pathFour = "";
            var pathFive = "";

            var pathSix = "";
            var pathSeven = "";
            var pathEight = "";
            var pathNine = "";
            var pathTen = "";
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
                            index.eventImagePathOne = fileOne.FileName;

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
                            pathTwo = Path.Combine(Server.MapPath("~/images"),fileTwo.FileName);
                            fileTwo.SaveAs(pathTwo);
                            index.eventImagePathTwo = fileTwo.FileName;
                        }
                    }
                }
                if (fileThree != null)
                {
                    if (fileThree.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileThree.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileThree.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileThree.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileThree.FileName).ToLower() == ".jpeg")
                        {
                            pathThree = Path.Combine(Server.MapPath("~/images"),fileThree.FileName);
                            fileThree.SaveAs(pathThree);
                            index.eventImagePathThree = fileThree.FileName;
                        }
                    }
                }
                if (fileFour != null)
                {
                    if (fileFour.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFour.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFour.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFour.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFour.FileName).ToLower() == ".jpeg")
                        {
                            pathFour = Path.Combine(Server.MapPath("~/images"),fileFour.FileName);
                            fileFour.SaveAs(pathFour);
                            index.eventImagePathFour = fileFour.FileName;
                        }
                    }
                }

                if (fileFive != null)
                {
                    if (fileFive.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFive.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFive.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFive.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFive.FileName).ToLower() == ".jpeg")
                        {
                            pathFive = Path.Combine(Server.MapPath("~/images"), fileFive.FileName);
                            fileFive.SaveAs(pathFive);
                            index.eventImagePathFive = fileFive.FileName;
                        }
                    }
                }

                if (fileSix != null)
                {
                    if (fileSix.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSix.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSix.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSix.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSix.FileName).ToLower() == ".jpeg")
                        {
                            pathSix = Path.Combine(Server.MapPath("~/images"),fileSix.FileName);
                            fileSix.SaveAs(pathSix);
                            index.teamImagePathOne = fileOne.FileName;

                        }
                    }

                }


                if (fileSeven != null)
                {
                    if (fileSeven.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSeven.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSeven.FileName).ToLower() == ".jpeg")
                        {
                            pathSeven = Path.Combine(Server.MapPath("~/images"),fileSeven.FileName);
                            fileSeven.SaveAs(pathSeven);
                            index.teamImagePathTwo = fileSeven.FileName;
                        }
                    }
                }
                if (fileEight != null)
                {
                    if (fileEight.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEight.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEight.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEight.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEight.FileName).ToLower() == ".jpeg")
                        {
                            pathEight = Path.Combine(Server.MapPath("~/images"),fileEight.FileName);
                            fileEight.SaveAs(pathEight);
                            index.teamImagePathThree = fileEight.FileName;
                        }
                    }
                }
                if (fileNine != null)
                {
                    if (fileNine.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileNine.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileNine.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileNine.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileNine.FileName).ToLower() == ".jpeg")
                        {
                            pathNine = Path.Combine(Server.MapPath("~/images"),fileNine.FileName);
                            fileNine.SaveAs(pathNine);
                            index.teamImagePathFour = fileFour.FileName;
                        }
                    }
                }

                if (fileTen != null)
                {
                    if (fileTen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTen.FileName).ToLower() == ".jpeg")
                        {
                            pathTen = Path.Combine(Server.MapPath("~/images"), fileTen.FileName);
                            fileTen.SaveAs(pathTen);
                            index.helpImagePath = fileTen.FileName;
                        }
                    }
                }
                db.Entry(index).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(index);
        }

        // GET: Index/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // POST: Index/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Index index = db.Indices.Find(id);
            db.Indices.Remove(index);
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
