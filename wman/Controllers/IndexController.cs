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
    public class IndexController : RouteController, IErrorController
    {
        public IndexController(HttpProcessor re) : base(re)
        {
        }

        [Route("/")]
        public void Home()
        {
            Success();

            var files = Directory.GetFiles(Man.ManFolder, "*.wman")
                .Select(Path.GetFileNameWithoutExtension);

            var context = new {files, title = "WMan - Home"};
            var templ = Resources.Template;
            string content = "{{#each files}}<a href='/Details/list?wman={{this}}'>{{this}}</a>{{/each}}";
            templ = templ.Replace(":content:", content);

            var template = Handlebars.Compile("index", templ);

            OutputStream.WriteLine(template(context));
        }

        public string OnError(Exception e)
        {
            var templ = Resources.Template;
            string content = "{{#with error}}{{stack}}{{/with}}";
            templ = templ.Replace(":content:", content);

            var template = Handlebars.Compile("error", templ);

            return template(new {error = new { stack = e.ToString() }});
        }
    }

    [Route("/Details/")]
    public class DetailsController : RouteController
    {
        public DetailsController(HttpProcessor re) : base(re)
        {
        }

        [Route("/Details/list")]
        public void List(string wman)
        {
            if (string.IsNullOrEmpty(wman))
            {
                throw new ArgumentNullException("No Wman given");
            }
            
            Success();

            var templ = Resources.Template;
            string content = "{{#each files}}<a href='/Details/item?wman={{wman}}&cmd={{cmd}}'>{{cmd}}</a>{{/each}}";

            templ = templ.Replace(":content:", content);

            var template = Handlebars.Compile("list", templ);
            OutputStream.WriteLine(template(new { title = "WMan - Details", files = new [] {"cout"}, wman }));
        }

        [Route("/Details/item")]
        public void Item(string wman, string cmd, int page = 0)
        {
            if (string.IsNullOrEmpty(wman))
            {
                throw new ArgumentNullException("No Wman given");
            }

            var m = new Man();
            var it = new PageItem
            {
                Name = "cout",
                Description = "Write something to console",
                Example = "std::cout << \"main function\" << std::endl;",
                SeeAlso = "http://en.cppreference.com/w/cpp/io/cout"
            };

            m.Items.Add(it);

            PageItem current = null;
            foreach (var p in m.Items)
            {
                if (p.Name == cmd)
                {
                    current = p;
                }
            }

            if (current == null)
            {
                throw new Exception("Page not found");
            }

            Success();

            var templ = Resources.Template;
            string content = "{{#with item}}" + 
                                "<h1><center>{{Name}}</center></h1>"+
                                "<p>{{Description}}</p>" +
                                "<p><h2>Example</h2><p>{{Example}}</p></p>" +
                                "<p><h2>See Also</h2><p><a href='{{SeeAlso}}'>{{SeeAlso}}</a></p></p>" +
                             "{{/with}}";

            templ = templ.Replace(":content:", content);

            var template = Handlebars.Compile("details", templ);
            OutputStream.WriteLine(template(new {title = "WMan - Details", item = current }));
        }
    }
}