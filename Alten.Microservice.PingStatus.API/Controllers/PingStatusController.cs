using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alten.VehicleStatus.PublisherSubscriber;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alten.Microservice.PingStatus.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PingStatusController : ControllerBase
    {
        static Client client;
        static Server server;
        readonly byte[] ipAddress = new byte[] { 127, 0, 0, 1 };
        readonly int portNumber = 7777;

        [HttpGet]      
        [ActionName("Send")]
        public IActionResult Send()
        {
            //initiate client 
            try
            {
                if (client == null)
                {
                    client = new Client(ipAddress, portNumber);
                }
                return new OkObjectResult(client.SendPingRequest());
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex.Message);
            }

        }
        [HttpGet]
        [ActionName("Listen")]
        public IActionResult Listen()
        {
            // listener
            try
            {
                if (server == null)
                    server = new Server(ipAddress, portNumber);
                server.Listen();
                return new OkObjectResult("up");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex.Message);
            }

        }
    }
}