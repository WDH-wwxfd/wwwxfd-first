using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class WDHController : Controller
    {
        //
        // GET: /WDH/

        public ActionResult Index()
        {
            Models.BookStoreEntities db = new Models.BookStoreEntities();
            var WDH = db.Books;
            return View(WDH);
        }

    }
}
