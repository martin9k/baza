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
    [RoutePrefix("api/v1/oddel")]
    public class OddelController : ApiController
    {
        HadlerOddel handlerOddel;

        public OddelController()
        {
            handlerOddel = new HadlerOddel();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetOddel([FromUri] int id)
        {
            try
            {
                var response = handlerOddel.HandlerGetoddel(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteOddel([FromUri] int id)
        {
            try
            {
                var response = handlerOddel.HandlerDeleteoddel(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostOddel([FromUri] string ime)
        {
            try
            {
                var response = handlerOddel.HandlerPostoddel(ime);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutOddel([FromUri] int id,string ime)
        {
            try
            {
                var response = handlerOddel.HandlerPutoddel(id,ime);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
