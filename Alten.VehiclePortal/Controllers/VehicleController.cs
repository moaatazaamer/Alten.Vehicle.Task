using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Alten.VehiclePortal.Config;
using Microsoft.AspNetCore.Mvc;

namespace Alten.VehiclePortal.Controllers
{
    public class VehicleController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult<string>> GetVehicles()
        {

            using (HttpClient client = new HttpClient())
            {
                UrlConfiguration urls = new UrlConfiguration();
                return await client.GetStringAsync(urls.vehicleCrudServiceBase + urls.vehicleCrudGetAll);
            }


        }
        [ActionName(name: "Listen")]
        public async Task<ActionResult<string>> Listen()
        {
            using (HttpClient client = new HttpClient())
            {
                UrlConfiguration urls = new UrlConfiguration();
                return await client.GetStringAsync(urls.vehicleStatusServiceBase + urls.vehicleStatusListen);
            }


        }
        [ActionName(name: "Send")]
        public async Task<ActionResult<string>> Send()
        {
            using (HttpClient client = new HttpClient())
            {
                UrlConfiguration urls = new UrlConfiguration();
                return await client.GetStringAsync(urls.vehicleStatusServiceBase + urls.vehicleStatusSend);
            }

        }
    }
}