using Alten.Microservice.VehicleStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.Microservice.VehicleStatus.DBContext
{
    public class VehicleContext
    {


        static Customer customer = new Customer() { Id = 1, Name = "Kalles Grustransporter AB", Address = "Cementvägen 8, 111 11 Södertälje" };
        static Customer customer2 = new Customer() { Id = 2, Name = "Johans Bulk AB", Address = "Balkvägen 12, 222 22 Stockholm" };
        static Customer customer3 = new Customer() { Id = 3, Name = "Haralds Värdetransporter AB", Address = "Budgetvägen 1, 333 33 Uppsala" };
        public static List<Vehicle> vehicles = new List<Vehicle>() {
                    new Vehicle()
        {
            Id = 1,
                        VId = "YS2R4X20005399401",
                        Owner = customer,
                        RegNr = "ABC123",Status = "Connected"
                    },
                    new Vehicle()
        {
            Id = 2,
                        VId = "VLUR4X20009093588",
                        Owner = customer,
                        RegNr = "DEF456",Status = "Disconnected"
                    },
                    new Vehicle()
        {
            Id = 3,
                        VId = "VLUR4X20009048066",
                        Owner = customer,
                        RegNr = "GHI789",Status = "Connected"
                    },
                    new Vehicle()
        {
            Id = 4,
                        VId = "YS2R4X20005388011",
                        Owner = customer2,
                        RegNr = "JKL012",Status = "Connected"
                    },
                    new Vehicle()
        {
            Id = 5,
                        VId = "YS2R4X20005387949",
                        Owner = customer2,
                        RegNr = "MNO345",Status = "Disconnected"
                    },
                    new Vehicle()
        {
            Id = 6,
                        VId = "VLUR4X20009048066",
                        Owner = customer3,
                        RegNr = "PQR678",Status = "Connected"
                    },
                    new Vehicle()
         {
            Id = 7,
                        VId = "YS2R4X20005387055",
                        Owner = customer3,
                        RegNr = "STU901",Status = "Connected"
                    }
    };
    }
}
