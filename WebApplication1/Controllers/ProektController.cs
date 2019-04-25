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
            public IHttpActionResult GetProekt([FromUri] int id3)
            {
                try
                {
                    var response = handlerProekt.HandlerGetproekt(id3);
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
                catch (Exception e)
                {
                    throw;
                }
            }
            [HttpPost]
            [Route("")]
            public IHttpActionResult PostProekt([FromUri] string ime)
            {
                try
                {
                    var response = handlerProekt.HandlerPostproekt(ime);
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
                try
                {
                    var response = handlerProekt.HandlerPutproekt(id, ime);
                    return Ok(response);
                }
                catch (Exception e)
                {
                    throw;
                }

            }
        }
    }
