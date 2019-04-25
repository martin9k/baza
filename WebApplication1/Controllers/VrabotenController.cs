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
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteVraboten([FromUri] int id4)
        {
            try
            {
                var response = handlerVraboten.HandlerDeletevraboten(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult PostVraboten([FromUri]int id_kredencijali,int id_oddel,int id_pozicija,string ime, string prezime, string grad, string adresa, string telefonski_broj)
        {
            try
            {
                var response = handlerVraboten.HandlerPostvraboten(id_kredencijali, id_oddel,id_pozicija,ime, prezime,grad,adresa,telefonski_broj);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutVraboten([FromUri]int id_vraboten,int id_kredencijali, int id_oddel, int id_pozicija, string ime, string prezime, string grad, string adresa, string telefonski_broj)
        {
            try
            {
                var response = handlerVraboten.HandlerPutvraboten(id_vraboten,id_kredencijali, id_oddel, id_pozicija, ime, prezime, grad, adresa, telefonski_broj);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
