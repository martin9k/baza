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
    [RoutePrefix("api/v1/task")]
    public class TaskController : ApiController
    {
        HandlerTask handlerTask;

        public TaskController()
        {
            handlerTask = new HandlerTask();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetZadaca([FromUri] int id4)
        {
            try
            {
                var response = handlerTask.HandlerGetzadaca(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetZadaci()
        {
            try
            {
                var response = handlerTask.HandlerGetzadaci();
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpDelete]
        [Route("")]
        public IHttpActionResult DeleteZadaca([FromUri] int id4)
        {
            try
            {
                var response = handlerTask.HandlerDeletezadaca(id4);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult PostZadaca([FromUri]int id_proekt, int id_vraboten,string naslov,string opis, int estimacija)
        {
            try
            {
                var response = handlerTask.HandlerPostzadaca(id_proekt, id_vraboten, naslov, opis, estimacija);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPut]
        [Route("")]
        public IHttpActionResult PutZadaca([FromUri]int id_zadaca,int id_proekt, int id_vraboten, int id_status, string datum_kreiranje, string datum_posledna_promena, string naslov,string opis, int estimacija, bool odobrena)
        {
            try
            {
                var response = handlerTask.HandlerPutzadaca(id_zadaca,id_proekt, id_vraboten, id_status, datum_kreiranje, datum_posledna_promena, naslov,opis,estimacija, odobrena);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpPut]
        [Route("update")]
        public IHttpActionResult UpdateStatus([FromUri]int id_zadaca,int id_status)
        {
            try
            {
                var response = handlerTask.HandlerUpdateStatus(id_zadaca, id_status);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

