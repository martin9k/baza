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
    [RoutePrefix("api/v1/kredencijal")]
    public class KredencijalController : ApiController
    {
        HandlerKredencijal handlerKredencijal;

        public KredencijalController()
        {
            handlerKredencijal = new HandlerKredencijal();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetKredencijal([FromUri] int id4)
        {
            try
            {
                var response = handlerKredencijal.HandlerGetkredencijal(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetKredencijali()
        {
            try
            {
                var response = handlerKredencijal.HandlerGetkredencijali();
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteKredencijal([FromUri] int id4)
        {
            try
            {
                var response = handlerKredencijal.HandlerDeletekredencija(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostKredencijal([FromUri]string korisnickoIme, string lozinka,bool aktiven)
        {
            try
            {
                var response = handlerKredencijal.HandlerPostkredencijal(korisnickoIme,lozinka,aktiven);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutKredencijal([FromUri]int id_Kredencijal,string korisnickoIme, string lozinka,bool aktiven)
        {
            try
            {
                var response = handlerKredencijal.HandlerPutkredencijal(id_Kredencijal,korisnickoIme,lozinka,aktiven);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
