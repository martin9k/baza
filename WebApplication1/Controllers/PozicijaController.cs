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
    [RoutePrefix("api/v1/pozicija")]
    public class PozicijaController : ApiController
    {
        HandlerPozicija handlerPozicija;

        public PozicijaController()
        {
            handlerPozicija = new HandlerPozicija();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetPozicija([FromUri] int id1)
        {
            try
            {
                var response = handlerPozicija.HandlerGetpozicija(id1);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetPozicii()
        {
            try
            {
                var response = handlerPozicija.HandlerGetpozicii();
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeletePozicija([FromUri] int id1)
        {
            try
            {
                var response = handlerPozicija.HandlerDeletepozicija(id1);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostPozicija([FromUri] string ime)
        {
            try
            {
                var response = handlerPozicija.HandlerPostpozicija(ime);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutPozicija([FromUri] int id, string ime)
        {
            try
            {
                var response = handlerPozicija.HandlerPutpozicija(id, ime);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
