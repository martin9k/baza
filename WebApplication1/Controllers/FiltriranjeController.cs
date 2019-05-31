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
    [RoutePrefix("api/v1/filtriranje")]
    public class FiltriranjeController : ApiController
    {
        HandlerFiltriranje handlerFiltriranje;

        public FiltriranjeController()
        {
            handlerFiltriranje = new HandlerFiltriranje();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetFiltriranje([FromUri] string id_proekt = null, string id_vraboten = null, string id_status = null, string naslov = null, string ime = null, string prezime = null)
        {if (string.IsNullOrWhiteSpace(naslov)) return BadRequest("naslov e prazen");
            if (string.IsNullOrWhiteSpace(ime)) return BadRequest("ime e prazen");
            if (string.IsNullOrWhiteSpace(prezime)) return BadRequest("prezime e prazen");
            try
            {
                var response = handlerFiltriranje.HandlerGetFiltriranje(id_proekt,id_vraboten, id_status, ime.Trim(), prezime.Trim(), naslov.Trim());
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
