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
    [RoutePrefix("api/v1/status")]
    public class StatusController : ApiController
    {
        HandlerStatus handlerStatus;

        public StatusController()
        {
            handlerStatus = new HandlerStatus();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetStatus([FromUri] int id3)
        {
            try
            {
                var response = handlerStatus.HandlerGetstatus(id3);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetStatusi()
        {
            try
            {
                var response = handlerStatus.HandlerGetstatusi();
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteStatus([FromUri] int id3)
        {
            try
            {
                var response = handlerStatus.HandlerDeletestatus(id3);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostStatus([FromUri] string ime)
        {
            try
            {
                var response = handlerStatus.HandlerPoststatus(ime);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutStatus([FromUri] int id, string ime)
        {
            try
            {
                var response = handlerStatus.HandlerPutstatus(id, ime);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
