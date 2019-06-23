using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            return View();
        }
         [HttpGet]

        public ActionResult Order()
        {
            return View();
        }

        [HttpPost]
         public ActionResult Order( int bookId,int num)
         {
           
             return View();
         }
    }
}
