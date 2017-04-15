using MyCompany.Visitors.Model;
using MyCompany.Visitors.Web.Infraestructure.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace MyCompany.Visitors.Web.Controllers
{
    /// <summary>
    /// CRMController integrates the CRMIntegrationService
    /// </summary>
    [RoutePrefix("api/crm")]
    [MyCompanyAuthorization]
    public class CRMController : ApiController
    {
        /// <summary>
        /// Get CRMData from CRMIntegrationService
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/crm/5
        [WebApiOutputCacheAttribute()]
        [Route("{id:int:min(1)}")]
        [Route("~/noauth/api/crm/{id:int:min(1)}")]
        public async Task<CRMData> Get(int id)
        {
            HttpClient client = new HttpClient();
            string hostname = "mycompany.visitors.crmsvc";

            Uri uri = new Uri($"http://{hostname}/api/crmdata/{id}");
            HttpResponseMessage response = await client.GetAsync(uri);

            HttpContent content = response.Content;
            CRMData returndata = await content.ReadAsAsync<CRMData>();

            return returndata;
        }
    }
}
