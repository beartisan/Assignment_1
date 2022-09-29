using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// returns "Hello World"
        /// <returns> "Hello World!" </returns>
        /// </summary>
        /// Post/api/Greeting
        /// api/Greeting
        /// </example>
        public String Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// returns statement (Greetings to {id} people!)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Greetings to {id} people!</returns>
        /// Post api/Greeting/{id}
        public string Post(int id)
        {
            string helloPeopleString = "Greetings to " + id + " people!";
            return helloPeopleString;
        }
    }
}