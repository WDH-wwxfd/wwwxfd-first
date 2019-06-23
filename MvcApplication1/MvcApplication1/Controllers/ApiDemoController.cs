using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ApiDemoController : ApiController
    {
        public string Helloworld()
        {
            return "Hello world";

        }
        [HttpGet]
        public int Add(int left, int right)
        {
            return left + right;
        }
    }
}

