using Core.Contracts;
using Core.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
namespace WebApplication1.Controllers
{
    [RoutePrefix("api/v1/report")]
    public class ReportController : ApiController
    {
        HandlerReport handlerReport;

        public ReportController()
        {
            handlerReport = new HandlerReport();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetReport([FromUri] int id_vraboten)
        {
            try
            {
                var response = handlerReport.HandlerGetReport(id_vraboten);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
