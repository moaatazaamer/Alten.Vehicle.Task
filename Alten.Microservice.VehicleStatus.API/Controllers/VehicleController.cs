using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Alten.Microservice.VehicleStatus.Models;
using Alten.Microservice.VehicleStatus.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alten.Microservice.VehicleStatus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        IVehicleRepository vehicleRepo=new VehicleRepository();
        // GET: api/Vehicle
        [HttpGet]
        public IActionResult Get()
        {
           return new OkObjectResult(vehicleRepo.GetAll());
        }

        // GET: api/Vehicle/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(vehicleRepo.GetById(id));
        }

        // POST: api/Vehicle
        [HttpPost]
        public IActionResult Post([FromBody] Vehicle vehicle)
        {
            using (var scope = new TransactionScope())
            {
                vehicleRepo.Add(vehicle);
                return new OkObjectResult("Addedd");
            }
        }

        // PUT: api/Vehicle/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            vehicleRepo.Update(vehicle);
           return new OkObjectResult("Updated");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            vehicleRepo.Delete(id);
            return new OkObjectResult("Deleted");
        }
    }
}
