using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLevio.Areas.adminstrator.Controllers
{
    public class DashboardController : Controller
    {
        // GET: adminstrator/Dashboard
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();

        }



        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult form()
        {
            return View();
        }

        public ActionResult Mandat()
        {
            return View();
        }
    }
}