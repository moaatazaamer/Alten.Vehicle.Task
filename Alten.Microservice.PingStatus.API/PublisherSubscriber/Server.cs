using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alten.VehicleStatus.PublisherSubscriber
{
    public class Server
    {
        Subscriber subscriber;
        public Server(byte[] ipAddress, int portNumber)
        {
            subscriber = new Subscriber(ipAddress, portNumber);
        }
        public void Listen()
        {
            try
            {
                Task task = Task.Factory.StartNew(() => subscriber.Listen());
                Task.WaitAll(task);
            }
            catch (Exception ex)
            {                
                throw;
            }
               
           
        }
    }
}
