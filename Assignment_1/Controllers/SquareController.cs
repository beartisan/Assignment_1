using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            /// summary
            /// returns (input^2)
            /// </summary>
            /// <param name="id"></param>
            /// <returns> input * input </returns>
            /// Get /api/Square/{id}
            /// api/Square/2
            /// </example>
            int square = id * id;
            return square;
        }
    }
}