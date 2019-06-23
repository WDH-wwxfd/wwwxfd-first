using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class WWXFDController : Controller
    {
        //
        // GET: /WWXFD/

        public ActionResult Index()
        {
            return View("~/Views/WWXFD/Team.cshtml");
        }

    }
}
