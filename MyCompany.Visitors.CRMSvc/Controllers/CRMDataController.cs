using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Visitors.CRMSvc.Controllers;

namespace MyCompany.Visitors.CRMSvc.Controllers
{
    [Produces("application/json")]
    [Route("api/CRMData")]
    public class CRMDataController : Controller
    {
        // GET: api/CRMData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {};
        }

        // GET: api/CRMData/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<CRMData> GetAsync(int id)
        {

            CRMData returndata = await GetCRMDataAsync(id);

            return returndata;
        }

        // POST: api/CRMData
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/CRMData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private async static Task<CRMData> GetCRMDataAsync(int id)
        {
            Random leads = new Random();

            CRMData returndata = new CRMData()
            {
                VisitorId = id,
                CRMAccountManager = "Cesar de_la_Torre",
                CRMLeads = leads.Next(0, 5)
            };

            return returndata;
        }

        public class CRMData
        {
            public int VisitorId { get; set; }
            public int CRMLeads { get; set; }
            public string CRMAccountManager { get; set; }
        }
    }

}

