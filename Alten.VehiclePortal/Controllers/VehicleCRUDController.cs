using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Alten.VehiclePortal.Controllers
{
    public class VehicleCRUDController : Controller
    {
         public async Task<ActionResult<string>> GetVehicles()
        {
            string url = "https://jsonplaceholder.typicode.com/todos"; // sample url
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }

        }
    }
}