using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemoApp.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {

        public static List<string> values = new List<string>()
        {
            "Advanced Video Upscaling, Compression and Enhancement",
            "Performance analysis and monitoring tools for Android",
            "Special-effects titling software for film and video",
            "In-app mobile messaging and push notification tools",
            "Bioinformatics solutions for life science research",
            "Application discovery and dashboard visualization",
            "Mobile business intelligence & Data visualization" 
        };
        // GET api/values
        [Route("")]
        public IEnumerable<string> Get()
        {
            return values;
        }

        [Route("{ind}")]
        // GET api/values/5
        public string Get(int ind)
        {
            return values[ind];
        }

        [Route("")]
        // POST api/values
        public void Post([FromBody] string value)
        {
            values.Add(value);
        }

        [Route("{ind}")]
        // PUT api/values/5
        public void Put(int ind, [FromBody] string value)
        {
            values[ind] = value;
        }

        [Route("{ind}")]
        // DELETE api/values/5
        public void Delete(int ind)
        {
            values.RemoveAt(ind);
        } 
    }
}
