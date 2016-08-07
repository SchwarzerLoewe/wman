using System;
using System.Collections.Generic;
using System.Threading;
using wman.Controllers;
using wman.Core.WebCore;

namespace wman
{
    class Program
    {
        //wman cpp 3 cout
        //wman install cpp
        //wman -web
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "install")
                {
                    PackageInstaller.Install(args[1]);
                }
                else if (args[0] == "-web")
                {
                    var httpServer = new RoutableHttpServer(8080);

                    Console.WriteLine("WebServer started at: http://localhost:8080/");
                    
                    RouteTable.Search();

                    Thread thread = new Thread(httpServer.listen);
                    thread.Start();
                }
                else
                {
                    PageViewer.Show(args);
                }
            }

            Console.ReadLine();
        }
    }
}