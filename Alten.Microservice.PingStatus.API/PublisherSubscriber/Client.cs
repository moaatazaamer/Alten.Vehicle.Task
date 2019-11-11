using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alten.VehicleStatus.PublisherSubscriber
{
   public class Client
    {
        static Publisher publisher;
        
        public Client(byte[] ipAddress, int portNumber)
        {
            if(publisher == null)
                publisher = new Publisher(ipAddress, portNumber);
        }
        public string SendPingRequest()
        {
            try
            {
                Task task = Task.Factory.StartNew(() => publisher.Send());
                Task.WaitAll(task);
                return publisher.message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}
