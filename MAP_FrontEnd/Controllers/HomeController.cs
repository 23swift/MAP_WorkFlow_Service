using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAP_FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MAS_MainFlow.ServiceClient MasMainflow = new MAS_MainFlow.ServiceClient();
            
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
