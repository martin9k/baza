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
        public IHttpActionResult GetFiltriranje([FromUri] int id_proekt, int id_vraboten, int id_status, string naslov, string ime, string prezime)
        {
            try
            {
                var response = handlerFiltriranje.HandlerGetFiltriranje(id_proekt, id_status, id_vraboten, ime, prezime, naslov);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
