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
    public class GalleryController : Controller
    {
        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();

        // GET: Gallery
        public ActionResult Index()
        {
            return View(db.Galleries.ToList());
        }

        // GET: Gallery/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery gallery = db.Galleries.Find(id);
            if (gallery == null)
            {
                return HttpNotFound();
            }
            return View(gallery);
        }

        // GET: Gallery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gallery/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TitleOne,ImagePathOne,ImagePathOneTwo,TitleTwo,BodyTwo,ImagePathTwo,ImagePathTwoTwo,TitleThree,BodyThree,ImagePathThree,ImagePathThreeTwo,TitleFour,BodyFour,ImagePathFour,ImagePathFourThree,TitleFive,BodyFive,ImagePathFive,ImagePathFiveFour,TitleSix,BodySix,ImagePathSix,ImagePathSixFive,TitleSeven,BodySeven,ImagePathSeven,ImagePathSevenSix,TitleEight,BodyEight,ImagePathEight,ImagePathEightSeven,TitleNine,BodyNine,ImagePathNine,ImagePathNineEight,TitleTen,BodyTen")] Gallery gallery, HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo, HttpPostedFileBase fileThree,

HttpPostedFileBase fileFour, HttpPostedFileBase fileFive, HttpPostedFileBase fileSix, HttpPostedFileBase fileSeven, HttpPostedFileBase fileEight,

HttpPostedFileBase fileNine, HttpPostedFileBase fileTen, HttpPostedFileBase fileEleven, HttpPostedFileBase fileTweleve, HttpPostedFileBase fileThirteen,

HttpPostedFileBase fileFourteen, HttpPostedFileBase fileFifteen, HttpPostedFileBase fileSixteen, HttpPostedFileBase fileSeventeen, HttpPostedFileBase fileEighteen)
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
            var pathEleven = "";
            var pathTweleve = "";
            var paththirteen = "";
            var pathfourteen = "";
            var pathFifteen = "";
            var pathSixteen = "";
            var pathSeventeen = "";
            var pathEighteen = "";

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
                            gallery.ImagePathOne = fileOne.FileName;

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
                            gallery.ImagePathOneTwo = fileTwo.FileName;
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
                            gallery.ImagePathTwo = fileThree.FileName;
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
                            pathFour = Path.Combine(Server.MapPath("~/images"), fileFour.FileName);
                            fileFour.SaveAs(pathFour);
                            gallery.ImagePathTwoTwo = fileFour.FileName;
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
                            pathFive = Path.Combine(Server.MapPath("~/images"),fileFive.FileName);
                            fileFive.SaveAs(pathFive);
                            gallery.ImagePathThree = fileFive.FileName;
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
                            pathSix = Path.Combine(Server.MapPath("~/images"), fileSix.FileName);
                            fileSix.SaveAs(pathSix);
                            gallery.ImagePathThreeTwo = fileSix.FileName;
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
                            pathSeven = Path.Combine(Server.MapPath("~/images"), fileSeven.FileName);
                            fileSeven.SaveAs(pathSix);
                            gallery.ImagePathFour = fileSeven.FileName;

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
                            pathEight = Path.Combine(Server.MapPath("~/images"), fileEight.FileName);
                            fileEight.SaveAs(pathEight);
                            gallery.ImagePathFourThree = fileEight.FileName;
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
                            pathNine = Path.Combine(Server.MapPath("~/images"), fileNine.FileName);
                            fileNine.SaveAs(pathNine);
                            gallery.ImagePathFive = fileNine.FileName;
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
                            pathTen = Path.Combine(Server.MapPath("~/images"),fileTen.FileName);
                            fileTen.SaveAs(pathTen);
                            gallery.ImagePathFiveFour = fileTen.FileName;
                        }
                    }
                }

                if (fileEleven != null)
                {
                    if (fileEleven.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEleven.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".jpeg")
                        {
                            pathEleven = Path.Combine(Server.MapPath("~/images"), fileEleven.FileName);
                            fileEleven.SaveAs(pathEleven);
                            gallery.ImagePathSix = fileEleven.FileName;
                        }
                    }
                }

                if (fileTweleve != null)
                {
                    if (fileTweleve.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTweleve.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".jpeg")
                        {
                            pathTweleve = Path.Combine(Server.MapPath("~/images"),fileTweleve.FileName);
                            fileTweleve.SaveAs(pathTweleve);
                            gallery.ImagePathSixFive = fileTweleve.FileName;

                        }
                    }

                }


                if (fileThirteen != null)
                {
                    if (fileThirteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileThirteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".jpeg")
                        {
                            paththirteen = Path.Combine(Server.MapPath("~/images"),fileThirteen.FileName);
                            fileThirteen.SaveAs(paththirteen);
                            gallery.ImagePathSeven = fileThirteen.FileName;
                        }
                    }
                }
                if (fileFourteen != null)
                {
                    if (fileFourteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFourteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".jpeg")
                        {
                            pathfourteen = Path.Combine(Server.MapPath("~/images"),fileFourteen.FileName);
                            fileFourteen.SaveAs(pathfourteen);
                            gallery.ImagePathSevenSix = fileFourteen.FileName;
                        }
                    }
                }
                if (fileFifteen != null)
                {
                    if (fileFifteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFifteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".jpeg")
                        {
                            pathFifteen = Path.Combine(Server.MapPath("~/images"),fileFifteen.FileName);
                            fileFifteen.SaveAs(pathFifteen);
                            gallery.ImagePathEight = fileFifteen.FileName;
                        }
                    }
                }

                if (fileSixteen != null)
                {
                    if (fileSixteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSixteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".jpeg")
                        {
                            pathSixteen = Path.Combine(Server.MapPath("~/images"), fileSixteen.FileName);
                            fileSixteen.SaveAs(pathSixteen);
                            gallery.ImagePathEightSeven = fileSixteen.FileName;
                        }
                    }
                }

                if (fileSeventeen != null)
                {
                    if (fileSeventeen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSeventeen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".jpeg")
                        {
                            pathSeventeen = Path.Combine(Server.MapPath("~/images"), fileSeventeen.FileName);
                            fileSeventeen.SaveAs(pathSeventeen);
                            gallery.ImagePathNine = fileSeventeen.FileName;
                        }
                    }
                }

                if (fileEighteen != null)
                {
                    if (fileEighteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEighteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".jpeg")
                        {
                            pathEighteen = Path.Combine(Server.MapPath("~/images"), fileEighteen.FileName);
                            fileEighteen.SaveAs(pathEighteen);
                            gallery.ImagePathNineEight = fileEighteen.FileName;
                        }
                    }
                }
                db.Galleries.Add(gallery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gallery);
        }

        // GET: Gallery/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery gallery = db.Galleries.Find(id);
            if (gallery == null)
            {
                return HttpNotFound();
            }
            return View(gallery);
        }

        // POST: Gallery/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TitleOne,ImagePathOne,ImagePathOneTwo,TitleTwo,BodyTwo,ImagePathTwo,ImagePathTwoTwo,TitleThree,BodyThree,ImagePathThree,ImagePathThreeTwo,TitleFour,BodyFour,ImagePathFour,ImagePathFourThree,TitleFive,BodyFive,ImagePathFive,ImagePathFiveFour,TitleSix,BodySix,ImagePathSix,ImagePathSixFive,TitleSeven,BodySeven,ImagePathSeven,ImagePathSevenSix,TitleEight,BodyEight,ImagePathEight,ImagePathEightSeven,TitleNine,BodyNine,ImagePathNine,ImagePathNineEight,TitleTen,BodyTen")] Gallery gallery , HttpPostedFileBase fileOne, HttpPostedFileBase fileTwo, HttpPostedFileBase fileThree,

HttpPostedFileBase fileFour, HttpPostedFileBase fileFive, HttpPostedFileBase fileSix, HttpPostedFileBase fileSeven, HttpPostedFileBase fileEight,

HttpPostedFileBase fileNine, HttpPostedFileBase fileTen, HttpPostedFileBase fileEleven, HttpPostedFileBase fileTweleve, HttpPostedFileBase fileThirteen,

HttpPostedFileBase fileFourteen, HttpPostedFileBase fileFifteen, HttpPostedFileBase fileSixteen, HttpPostedFileBase fileSeventeen, HttpPostedFileBase fileEighteen)
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
            var pathEleven = "";
            var pathTweleve = "";
            var paththirteen = "";
            var pathfourteen = "";
            var pathFifteen = "";
            var pathSixteen = "";
            var pathSeventeen = "";
            var pathEighteen = "";

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
                            gallery.ImagePathOne = fileOne.FileName;

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
                            fileTwo.SaveAs(pathTwo);
                            gallery.ImagePathOneTwo = fileTwo.FileName;
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
                            pathThree = Path.Combine(Server.MapPath("~/images"), fileThree.FileName);
                            fileThree.SaveAs(pathThree);
                            gallery.ImagePathTwo = fileThree.FileName;
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
                            pathFour = Path.Combine(Server.MapPath("~/images"), fileFour.FileName);
                            fileFour.SaveAs(pathFour);
                            gallery.ImagePathTwoTwo = fileFour.FileName;
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
                            gallery.ImagePathThree = fileFive.FileName;
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
                            pathSix = Path.Combine(Server.MapPath("~/images"), fileSix.FileName);
                            fileSix.SaveAs(pathSix);
                            gallery.ImagePathThreeTwo = fileSix.FileName;
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
                            pathSeven = Path.Combine(Server.MapPath("~/images"), fileSeven.FileName);
                            fileSeven.SaveAs(pathSix);
                            gallery.ImagePathFour = fileSeven.FileName;

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
                            pathEight = Path.Combine(Server.MapPath("~/images"), fileEight.FileName);
                            fileEight.SaveAs(pathEight);
                            gallery.ImagePathFourThree = fileEight.FileName;
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
                            pathNine = Path.Combine(Server.MapPath("~/images"), fileNine.FileName);
                            fileNine.SaveAs(pathNine);
                            gallery.ImagePathFive = fileNine.FileName;
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
                            gallery.ImagePathFiveFour = fileTen.FileName;
                        }
                    }
                }

                if (fileEleven != null)
                {
                    if (fileEleven.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEleven.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEleven.FileName).ToLower() == ".jpeg")
                        {
                            pathEleven = Path.Combine(Server.MapPath("~/images"), fileEleven.FileName);
                            fileEleven.SaveAs(pathEleven);
                            gallery.ImagePathSix = fileEleven.FileName;
                        }
                    }
                }

                if (fileTweleve != null)
                {
                    if (fileTweleve.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileTweleve.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileTweleve.FileName).ToLower() == ".jpeg")
                        {
                            pathTweleve = Path.Combine(Server.MapPath("~/images"), fileTweleve.FileName);
                            fileTweleve.SaveAs(pathTweleve);
                            gallery.ImagePathSixFive = fileTweleve.FileName;

                        }
                    }

                }


                if (fileThirteen != null)
                {
                    if (fileThirteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileThirteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileThirteen.FileName).ToLower() == ".jpeg")
                        {
                            paththirteen = Path.Combine(Server.MapPath("~/images"), fileThirteen.FileName);
                            fileThirteen.SaveAs(paththirteen);
                            gallery.ImagePathSeven = fileThirteen.FileName;
                        }
                    }
                }
                if (fileFourteen != null)
                {
                    if (fileFourteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFourteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFourteen.FileName).ToLower() == ".jpeg")
                        {
                            pathfourteen = Path.Combine(Server.MapPath("~/images"), fileFourteen.FileName);
                            fileFourteen.SaveAs(pathfourteen);
                            gallery.ImagePathSevenSix = fileFourteen.FileName;
                        }
                    }
                }
                if (fileFifteen != null)
                {
                    if (fileFifteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileFifteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileFifteen.FileName).ToLower() == ".jpeg")
                        {
                            pathFifteen = Path.Combine(Server.MapPath("~/images"), fileFifteen.FileName);
                            fileFifteen.SaveAs(pathFifteen);
                            gallery.ImagePathEight = fileFifteen.FileName;
                        }
                    }
                }

                if (fileSixteen != null)
                {
                    if (fileSixteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSixteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSixteen.FileName).ToLower() == ".jpeg")
                        {
                            pathSixteen = Path.Combine(Server.MapPath("~/images"), fileSixteen.FileName);
                            fileSixteen.SaveAs(pathSixteen);
                            gallery.ImagePathEightSeven = fileSixteen.FileName;
                        }
                    }
                }

                if (fileSeventeen != null)
                {
                    if (fileSeventeen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileSeventeen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileSeventeen.FileName).ToLower() == ".jpeg")
                        {
                            pathSeventeen = Path.Combine(Server.MapPath("~/images"), fileSeventeen.FileName);
                            fileSeventeen.SaveAs(pathSeventeen);
                            gallery.ImagePathNine = fileSeventeen.FileName;
                        }
                    }
                }

                if (fileEighteen != null)
                {
                    if (fileEighteen.ContentLength > 0)
                    {
                        if (Path.GetExtension(fileEighteen.FileName).ToLower() == ".jpg"

                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".png"
                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".gif"
                          || Path.GetExtension(fileEighteen.FileName).ToLower() == ".jpeg")
                        {
                            pathEighteen = Path.Combine(Server.MapPath("~/images"), fileEighteen.FileName);
                            fileEighteen.SaveAs(pathEighteen);
                            gallery.ImagePathNineEight = fileEighteen.FileName;
                        }
                    }
                }
                db.Entry(gallery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gallery);
        }

        // GET: Gallery/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery gallery = db.Galleries.Find(id);
            if (gallery == null)
            {
                return HttpNotFound();
            }
            return View(gallery);
        }

        // POST: Gallery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gallery gallery = db.Galleries.Find(id);
            db.Galleries.Remove(gallery);
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
