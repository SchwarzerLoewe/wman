using System;
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

        [Route("/")]
        public void Home()
        {
            Success();

            var files = Directory.GetFiles(Man.ManFolder, "*.wman").Select(Path.GetFileNameWithoutExtension);

            var context = new {files = files};
            var templ = Resources.Template;
            string content = "{{#each files}}<a href='/Details/item?wman={{this}}'>{{this}}</a>{{/each}}";
            templ = templ.Replace(":content:", content);

            var template = Handlebars.Compile("index", templ);

            OutputStream.WriteLine(template(context));
        }
    }

    [Route("/Details/")]
    public class DetailsController : RouteController
    {
        public DetailsController(HttpProcessor re) : base(re)
        {
        }

        [Route("/Details/item")]
        public void Item(string wman, int page = 0)
        {
            if (string.IsNullOrEmpty(wman))
            {
                throw new ArgumentNullException("No Wman given");
            }
            Success();

            var templ = Resources.Template;
            templ = templ.Replace(":content:", "wman: " + wman + " on page: " + page);

            var template = Handlebars.Compile("details", templ);
            OutputStream.WriteLine(template(null));
        }
    }
}