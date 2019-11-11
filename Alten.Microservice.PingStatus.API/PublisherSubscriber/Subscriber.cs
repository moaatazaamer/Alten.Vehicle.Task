using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Alten.VehicleStatus.PublisherSubscriber
{
    public class Subscriber
    {
        private Socket listener;
        readonly byte[] localhost;
        readonly int port;
        int count;
        string data;
        //listen to port
        public Subscriber(byte[] localhost, int port)
        {
            this.localhost = localhost;
            this.port = port;
           
        }

        //receive response from sender
        public void Listen()
        {
            byte[] buffer;
            string response = String.Empty;
            IPAddress address = new IPAddress(localhost);
            IPEndPoint endPoint = new IPEndPoint(address, port);
           
            try
            {
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(endPoint);
                listener.Listen(3);
                while (true)
                {
                    buffer = new byte[256];
                    Socket receiver = listener.Accept();
                    while (true)
                    {
                        count = receiver.Receive(buffer);
                        data = Encoding.UTF8.GetString(buffer, 0, count);
                        response = data;
                        // Send response
                        receiver.Send(Encoding.UTF8.GetBytes(response));
                        break;

                    }
                    // close connection
                    receiver.Shutdown(SocketShutdown.Both);
                    receiver.Close();
                }

            }
            catch (System.Net.Sockets.SocketException ex)
            {
                listener.Disconnect(true);
                // Exception handling
            }
        }
    }
}
