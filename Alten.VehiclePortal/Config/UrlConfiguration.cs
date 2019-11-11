using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.VehiclePortal.Config
{
    public class UrlConfiguration
    {
        public string vehicleCrudServiceBase { get; }
        public string vehicleStatusServiceBase { get; }
        public string vehicleCrudGetAll { get; }
        public string vehicleStatusListen { get; }
        public string vehicleStatusSend { get; }
        public UrlConfiguration()
        {
            Configration urlConfig = new Configration();                       
            vehicleCrudServiceBase = urlConfig.config.GetSection("Urls").GetSection("Services").GetSection("VehicleCRUD").GetSection("Base").Value;
            vehicleStatusServiceBase = urlConfig.config.GetSection("Urls").GetSection("Services").GetSection("VehicleStatus").GetSection("Base").Value;
            vehicleCrudGetAll = urlConfig.config.GetSection("Urls").GetSection("Services").GetSection("VehicleCRUD").GetSection("GetAll").Value;
            vehicleStatusListen = urlConfig.config.GetSection("Urls").GetSection("Services").GetSection("VehicleStatus").GetSection("Listen").Value;
            vehicleStatusSend = urlConfig.config.GetSection("Urls").GetSection("Services").GetSection("VehicleStatus").GetSection("Send").Value;
            
        }
      

    }
}
