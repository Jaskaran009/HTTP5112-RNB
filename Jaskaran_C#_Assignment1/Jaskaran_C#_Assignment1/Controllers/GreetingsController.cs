using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class GreetingsController :ApiController
    {
        // GET: Greetings
        public string Get(int id)
        {
            string Greet = "Greetings to ";
            string NoOfPeople = " people!";
            return Greet + id + NoOfPeople;
            //summary -created the get method
            //initiated strings with comments and returned the value of string and integer 
            //for ex : for 3 people it would be greetings to 3 people!
            //Similarly for 4 people it woule be greetung to 4 people!
        }
    }
}