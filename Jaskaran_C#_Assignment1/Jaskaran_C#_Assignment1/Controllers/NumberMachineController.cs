using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jaskaran_C__Assignment1.Controllers
{
    public class NumberMachineController :ApiController
    {
        // GET: NumberMachine
        public string Get(int id )
        {
            string command1 = "Multiplication of 2 with ";
            string command2 = "Addition of 2 with ";
            string command3 = "Divison of 2 with ";
            string command4 = "Subtraction of 2 from ";
            string command5 = " is ";


            var multiply = id * 2;
            var add = id + 2;
            var divison = id / 2;
            var subtract = id - 2;
            return command1 + id + command5 + multiply +  
                "," + command2 + id + command5 + add + 
                "," + command3 + id+ command5+ divison + 
                "," + command4 +id + command5 +subtract  ;
            //summary- declared 4 variables to store the output of operators with input value
            //returned the integer and string values to output the results in sentence
            //for example : for input value 4 multiplication will be 8, 
            //addition will be 6, divison will be 2, subtraction will be 2
          

        }
    }
}