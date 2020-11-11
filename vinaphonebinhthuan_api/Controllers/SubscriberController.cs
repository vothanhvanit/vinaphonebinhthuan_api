using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vinaphonebinhthuan_api.Dao;
using vinaphonebinhthuan_api.Models;

namespace vinaphonebinhthuan_api.Controllers
{
   [RoutePrefix("subscribers")]
    public class SubscriberController : ApiController
    {
        // GET: api/Subscriber
        [Route("")]
        public IEnumerable<SubscriberVina> Get()
        {
            SubscriberVinaDao dao = new SubscriberVinaDao();
            return dao.FindSubsVNP("12");
        }

        // GET: api/Subscriber/5
        [Route("{mobile}")]
        public object Get(string mobile)
        {
            SubscriberVinaDao dao = new SubscriberVinaDao();
            return dao.FindSubsVNP(mobile);
        }

        // POST: api/Subscriber
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subscriber/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subscriber/5
        public void Delete(int id)
        {
        }
    }
}
