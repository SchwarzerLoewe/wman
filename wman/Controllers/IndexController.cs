using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using wman.Core;
using wman.Core.TemplateEngine;
using wman.Core.WebCore;
using wman.Properties;

namespace wman.Controllers
{
    [Route("/")]
    public class IndexController : RouteController
    {
        public IndexController(HttpProcessor re) : base(re)
        {
        }

        [Route]
        public void Home()
        {
            Success();

            var files = Directory.GetFiles(Man.ManFolder, "*.wman").Select(Path.GetFileNameWithoutExtension);

            var context = new {files = files};

            var template = Handlebars.Compile("index", "<html><head><title>Details</title>{{icon 'favicon'}}</head><body>{{#each files}}<a href='/Details/item?wman={{this}}'>{{this}}</a>{{/each}}</body></html>");

            OutputStream.WriteLine(template(context));
        }

        [Route("/set")]
        public void Set(int my, string s)
        {
            if (my <= 0) throw new ArgumentOutOfRangeException(nameof(my));

            Success();

            var uri = Extensions.GetDataURL(Resources.favicon.ToBitmap());
            var context = new {world = s, my = my, favicon = uri};

            var template = Handlebars.Compile("index", "<html><head><title>Details</title><link rel='icon' href='{{favicon}}' type='image/png'></head><body>Hello {{world}}! ({{my}})</body></html>");

            OutputStream.WriteLine(template(context));
            //OutputStream.WriteLine("Value: " + query.GetValue<float>("myInt"));
        }
    }

    [Route("/Details/")]
    public class DetailsController : RouteController
    {
        public DetailsController(HttpProcessor re) : base(re)
        {
        }

        [Route]
        public void Home()
        {
            Error();

            OutputStream.WriteLine("No WMan given");
        }

        [Route("/Details/item")]
        public void Item(string wman)
        {
            Success();

            var template = Handlebars.Compile("details",
                "<html><head><title>Details</title>{{icon 'favicon'}}</head><body>" + wman +"</body></html>");
            
            OutputStream.WriteLine(template(null));
        }
    }
}