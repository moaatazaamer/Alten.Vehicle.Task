using System;
using Xunit;
using Alten.Microservice.VehicleStatus.API.Controllers;
using Newtonsoft.Json;
using System.Collections.Generic;
using Alten.Microservice.VehicleStatus.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http;

namespace Alten.Microservice.VehicleAPI.Test
{
    public class CrudTest
    {
        [Fact]
        public  void GetAll()
        {
            VehicleController vehicle = new VehicleController();
            var actualtResult = vehicle.Get();
           Assert.IsType<OkObjectResult>(actualtResult);

        }
        [Fact]
        public void GetById()
        {
            VehicleController vehicle = new VehicleController();
            var actualtResult = vehicle.Get(2);
            Assert.IsType<OkObjectResult>(actualtResult);
        }
        [Fact]
        public void Instert()
        {
            VehicleController vehicle = new VehicleController();
            var actualtResult = vehicle.Post(ResultSetUp.singleVehicle);
            Assert.IsType<OkObjectResult>(actualtResult);
        }
        [Fact]
        public void Delete()
        {
            VehicleController vehicle = new VehicleController();
            var actualtResult = vehicle.Delete(3);
            Assert.IsType<OkObjectResult>(actualtResult);
        }
        [Fact]
        public void Update()
        {
            VehicleController vehicle = new VehicleController();
            var actualtResult = vehicle.Put(ResultSetUp.singleVehicle.Id , ResultSetUp.singleVehicle);
            Assert.IsType<OkObjectResult>(actualtResult);
        }
    }
}
