using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;


namespace server
{
    class Server 
    {
        TcpListener Listern;
        public Server(int Port)
        {
            Listern = new TcpListener(IPAddress.Any, Port);
            Listern.Start();

            while (true)
            {
                Listern.AcceptTcpClient();
            }
        }
        ~Server()
        {
            if (Listern != null)
            {
                Listern.Stop();
            }
        }
        
    }
}
