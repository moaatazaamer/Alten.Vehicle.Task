using Alten.Microservice.VehicleStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.Microservice.VehicleStatus.Repository
{
   public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle GetById(int id);
        void Add(Vehicle entity);
        void Delete(int id);
        void Update(Vehicle entity);
    }
}
