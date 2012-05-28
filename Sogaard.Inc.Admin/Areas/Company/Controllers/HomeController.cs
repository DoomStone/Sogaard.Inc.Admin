using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sogaard.Inc.Admin.Areas.Company.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Company/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
