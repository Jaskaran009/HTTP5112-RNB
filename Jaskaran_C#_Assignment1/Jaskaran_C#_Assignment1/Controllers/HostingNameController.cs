using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class HostingNameController : ApiController
    {
        
        // GET: Hosting
        public decimal Get(int id)
        {
           
            int fortnight = (int)id/7;
            double fortprice = fortnight * 5.50;
            double taxonprice = fortprice * 0.13;
            double totalprice= taxonprice + fortprice;
            return (decimal)totalprice; 
            //1 fortnight = 7 days
            //calculated fortprice by dividing the total days by 7 and then multiplying it by 5.50
            //calculated tax by mutiplying it by HST 0.13(13%)
            //Totaprice charged is equal to taxtotal+ fortprice;
            
        }
    }
}