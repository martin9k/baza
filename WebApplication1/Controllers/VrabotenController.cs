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
    [RoutePrefix("api/v1/vraboten")]

    public class VrabotenController : ApiController
    {
        HandlerVraboten handlerVraboten;

        public VrabotenController()
        {
            handlerVraboten = new HandlerVraboten();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetVraboten([FromUri] int id4)
        {
            try
            {
                var response = handlerVraboten.HandlerGetvraboten(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetVraboteni()
        {
            try
            {
                var response = handlerVraboten.HandlerGetvraboteni();
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteVraboten([FromUri] int id4)
        {
            try
            {
                var response = handlerVraboten.HandlerDeletevraboten(id4);
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
        public IHttpActionResult PostVraboten([FromUri]int id_kredencijali,int id_oddel,int id_pozicija,string ime, string prezime, string grad, string adresa, string telefonski_broj,string mail)
        {if (string.IsNullOrWhiteSpace(ime)) return BadRequest("ime e prazno");
            if (string.IsNullOrWhiteSpace(prezime)) return BadRequest("prezime e prazno");
            if (string.IsNullOrWhiteSpace(grad)) return BadRequest("grad e prazno");
            if (string.IsNullOrWhiteSpace(adresa)) return BadRequest("adresa e prazno");
            if (string.IsNullOrWhiteSpace(telefonski_broj)) return BadRequest("telefonski_broj e prazno");
            if (string.IsNullOrWhiteSpace(mail)) return BadRequest("mail e prazno");
            try
            {
                var response = handlerVraboten.HandlerPostvraboten(id_kredencijali, id_oddel,id_pozicija,ime.Trim(), prezime.Trim(), grad.Trim(), adresa.Trim(), telefonski_broj.Trim(), mail.Trim());
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutVraboten([FromUri]int id_vraboten,int id_kredencijali, int id_oddel, int id_pozicija, string ime, string prezime, string grad, string adresa, string telefonski_broj,string mail)
        {
            if (string.IsNullOrWhiteSpace(ime)) return BadRequest("ime e prazno");
            if (string.IsNullOrWhiteSpace(prezime)) return BadRequest("prezime e prazno");
            if (string.IsNullOrWhiteSpace(grad)) return BadRequest("grad e prazno");
            if (string.IsNullOrWhiteSpace(adresa)) return BadRequest("adresa e prazno");
            if (string.IsNullOrWhiteSpace(telefonski_broj)) return BadRequest("telefonski_broj e prazno");
            if (string.IsNullOrWhiteSpace(mail)) return BadRequest("mail e prazno");
            try
            {
                var response = handlerVraboten.HandlerPutvraboten(id_vraboten,id_kredencijali, id_oddel, id_pozicija, ime.Trim(), prezime.Trim(), grad.Trim(), adresa.Trim(), telefonski_broj.Trim(), mail.Trim());
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
