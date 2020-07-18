using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace PracticeJQueryAjax.Controllers
{
    public class TestClass
    {
        public string Test { get; set; }
    }

    public class PracticeController : ApiController
    {
        //// GET: api/Practice
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        public string Get()
        {
            Thread.Sleep(2000);
            return "This text came from the server's GET action method";
        }


        [HttpPost]
        public string Post([FromBody] TestClass testClass)
        {
            Thread.Sleep(2000);
            return "This text came from the server's POST action method";
        }



        //// GET: api/Practice/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Practice
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Practice/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Practice/5
        //public void Delete(int id)
        //{
        //}
    }
}
