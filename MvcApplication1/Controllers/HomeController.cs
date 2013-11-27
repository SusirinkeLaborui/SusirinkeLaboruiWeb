using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Live;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Team Page";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Downloads()
        {
            ViewBag.Message = "Download the build and spec here!";
            return View();
        }

        //public ActionResult DownloadSpec()
        //{
        //    MemoryStream stream = someService.GetStream();
        //    LiveConnectClient liveClien = "test";
        //    return new FileStreamResult(stream, "application/pdf");
        //}
    }
}
