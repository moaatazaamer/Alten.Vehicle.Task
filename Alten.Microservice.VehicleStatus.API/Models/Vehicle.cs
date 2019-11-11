using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.Microservice.VehicleStatus.Models
{
    public class Vehicle
    {
        public int Id{ get; set; }
        public string VId { get; set; }
        public string RegNr { get; set; }
        public string Status { get; set; }
        public Customer Owner { get; set; }
    }
}
