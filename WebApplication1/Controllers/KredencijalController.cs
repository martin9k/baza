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
        [Route("validacija")]
        public IHttpActionResult GetKorisnik([FromUri] string korisnickoime,string lozinka)
        {
            try
            { var  response = handlerKredencijal.HandlerGetKorsnik(korisnickoime,lozinka);
                if (response == null)
                {
                    return Ok(response);
                }
                else
                {
                    return Content(HttpStatusCode.Forbidden, "Access denied.");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
                throw;
            }
        }

        private IHttpActionResult BadRequest(Exception e)
        {
            throw new NotImplementedException();
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
