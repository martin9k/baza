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
    [RoutePrefix("api/v1/proekt")]
    public class ProektController : ApiController
    {
            HandlerProekt handlerProekt;

            public ProektController()
            {
                handlerProekt = new HandlerProekt();
            }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetProekt(int id_proekt)
        {
            try
            {
                var response = handlerProekt.HandlerGetproekt(id_proekt);
                return Ok(response);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        [HttpGet]
            [Route("all")]
            public IHttpActionResult GetProekti()
            {
                try
                {
                    var response = handlerProekt.HandlerGetproekti();
                    return Ok(response);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            [HttpDelete]
            [Route("")]
            public IHttpActionResult DeleteProekt([FromUri] int id3)
            {
                try
                {
                    var response = handlerProekt.HandlerDeleteproekt(id3);
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
            public IHttpActionResult PostProekt([FromUri] string ime)
            {if (string.IsNullOrWhiteSpace(ime)) return BadRequest("proekt e prazen");
                try
                {
                    var response = handlerProekt.HandlerPostproekt(ime.Trim());
                    return Ok(response);
                }
                catch (Exception e)
                {
                    throw;
                }

            }
            [HttpPut]
            [Route("")]
            public IHttpActionResult PutProekt([FromUri] int id, string ime)
            {
            if (string.IsNullOrWhiteSpace(ime)) return BadRequest("proekt e prazen");
            try
                {
                    var response = handlerProekt.HandlerPutproekt(id, ime.Trim());
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
