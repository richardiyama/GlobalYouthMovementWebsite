using GlobalYouthWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace GlobalYouthWeb.Controllers
{
    public class HomeController : Controller
    {

        private GlobalYouthWebContextDB db = new GlobalYouthWebContextDB();
        public ActionResult Index()
        {
            return View(db.Indices.ToList());
        }

        public ActionResult About()
        {


            return View(db.Abouts.ToList());
        }

        public ActionResult Gallery()
        {


            return View(db.Galleries.ToList());
        }

        public ActionResult Event()
        {


            return View(db.Events.ToList());
        }

        public ActionResult Blog()
        {


            return View(db.Blogs.ToList());
        }

        
        public ActionResult SingleBlog(int? id)
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
        public ActionResult Contact()
        {


            return View(db.Contacts.ToList());
        }
    }
}
