using System;
using wman.Core.TemplateEngine;
using wman.Core.WebCore;

namespace wman.Controllers
{
    [Route("/")]
    public class IndexController : RouteController
    {
        public IndexController(HttpProcessor re) : base(re)
        {
        }

        [Route]
        public void Home(int my)
        {
            Success();

            string result = Handlebars.CompileAndRun("index", "Hello {{world}}!", new { world = "World" });

            OutputStream.WriteLine(result);
            //OutputStream.WriteLine("Value: " + query.GetValue<float>("myInt"));
        }
    }
}