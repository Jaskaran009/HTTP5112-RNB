using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        // GET: Greeting
        public string Get()
        {
            string Greet = "Hello World!";
            return Greet;
        }
    }
}
//summary - returned the value of greet //
