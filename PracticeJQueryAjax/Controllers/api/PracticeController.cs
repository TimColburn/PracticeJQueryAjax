using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeJQueryAjax.Controllers
{
    public class PracticeController : ApiController
    {
        //// GET: api/Practice
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        public string Get()
        {
            return "test";
        }

        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "data from AJAX Post";
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
