using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            /// <summary>
            /// returns (input+10)
            /// </summary>
            /// <param name="id"></param>
            /// <returns> input + 10</returns>
            /// Get /api/AddTen/{id}
            /// <example>
            /// api/AddTen/45
            /// </example>
            int addTen = id + 10;
            return addTen;
        }
    }
}
