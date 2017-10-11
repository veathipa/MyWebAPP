using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPP.Controllers
{
    public class LogicAppController : ApiController
    {
        List<string> names = new List<string>() { "Venky", "Alka", "Arshi", "Sudha", "Swathi", "Gulla" };
        // GET: api/LogicApp
        public IEnumerable<string> Get()
        {
            return names;
        }

        // GET: api/LogicApp/5
        public string Get(int id)
        {
            if (names.Count > id)
            {
                return names[id];
            }
            return "NoNameFound";
        }

        // POST: api/LogicApp
        public void Post([FromBody]string value)
        {
            names.Add(value);
        }

        // PUT: api/LogicApp/5
        public void Put(int id, [FromBody]string value)
        {
            if (names.Count > id)
            {
                names[id] = value;
            }
        }

        // DELETE: api/LogicApp/5
        public void Delete(int id)
        {
            if (names.Count > id)
            {
                names.RemoveAt(id);
            }
        }
    }
}
