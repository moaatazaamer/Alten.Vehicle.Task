using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alten.Microservice.VehicleStatus.DBContext;
using Alten.Microservice.VehicleStatus.Models;

namespace Alten.Microservice.VehicleStatus.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        
        public void Add(Vehicle entity)
        {
            VehicleContext.vehicles.Add(entity);
        }

        public void Delete(int id)
        {
            VehicleContext.vehicles.Remove(GetById(id));
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return VehicleContext.vehicles;
        }

        public Vehicle GetById(int id)
        {
            return VehicleContext.vehicles.FirstOrDefault(v => v.Id == id);
        }

        public void Update(Vehicle entity)
        {
            VehicleContext.vehicles[entity.Id] = entity;
        }
    }
}
