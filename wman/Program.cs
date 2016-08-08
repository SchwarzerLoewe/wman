using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using wman.Controllers;
using wman.Core;
using wman.Core.TemplateEngine;
using wman.Core.WebCore;
using wman.Properties;

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

                    Handlebars.RegisterHelper("icon", options =>
                    {
                        var i = Resources.ResourceManager.GetObject(options.Data);
                        var uri = Extensions.GetDataURL(((Icon)i).ToBitmap());
                        return "<link rel='icon' href='" + uri + "' type='image/png'>";
                    });
                    Handlebars.RegisterHelper("res", options =>
                    {
                        var i = Resources.ResourceManager.GetObject(options.Data);

                        return i.ToString();
                    });

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