using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class AddTenController:ApiController
    {
        // GET: AddTen
        public int Get (int id)
        {
            int total = id + 10;
            return total;
            //created get method 
            //stored the value of input id + 10 in total var type integer
            //returned value of total
            //for ex- for 1 it will be 11
            //for 20 it would be 30
        }
    }
}