using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class SquareController:ApiController
    {
        // GET: Square
        public int Get (int id)
        {
            int square = id * id;
            return square;
            //created get method 
            //stored the value of input id*id in square var type integer
            //returned value of square
            //for example- for 2 it will be 4
            //for 4 it would be 16
        }
    }
}