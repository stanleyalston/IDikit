using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDikit.Core.Model;
using IDikit.Core.Services;

namespace IDikit.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSiteDetails()
        {
            var bookmark = new Bookmark();

            return Json(bookmark.GetList().OrderByDescending(c => c.ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveBookMark(string url)
        {
            var bookmark = new Bookmark();
            bookmark.Save(new Bookmark 
                            { 
                                Link = url,
                                Title = "Google",
                                Description = "Sample Description",
                                Member = 1,
                                Status = "Active"
                            });

            return Json(new { Output = "Saved" }, JsonRequestBehavior.AllowGet);
        }
    }
}
