using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeviantGames.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
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
            ViewBag.Message = "😈 Deviant Games 😈";

            return View();
        }

    }
}