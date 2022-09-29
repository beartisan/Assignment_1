using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    /// <summary>
    /// returns (input+10)
    /// </summary>
    /// <param name="id"></param>
    /// <returns> ((input*4) + 20 / 2 ) -7</returns>
    /// Get/api/NumberMachine/{id}
    /// <example>
    /// api/NumberMachine/22
    /// Multiply input by 4
    /// product 88 plus 20
    /// sum 108 divides by 2
    /// half 54 minus 7
    /// Returns 47
    /// </example>
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int product = id * 4;
            int sum = product + 20;
            int half = sum / 2;
            int minus = half - 7;
            return minus;
        }
    }
}