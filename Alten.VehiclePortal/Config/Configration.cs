using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alten.VehiclePortal.Config
{
    public class Configration:IDisposable
    {
        public IConfiguration config { get; }
        public Configration()
        {
            config = GetConfiguration();
        }
        IConfigurationRoot GetConfiguration()
        {
            var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);
            return configBuilder.Build();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
