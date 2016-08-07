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

        [Route()]
        public void Home()
        {
            Success();

            OutputStream.WriteLine("Hello World");
        }

        [Route("/set")]
        public void Set(int my, string s)
        {
            Success();

            string result = Handlebars.CompileAndRun("index", "Hello {{world}}! ({{my}})", new { world = s, my = my });

            OutputStream.WriteLine(result);
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
            Success();

            OutputStream.WriteLine("Detailspage");
        }

        [Route("/Details/item")]
        public void Item(int index)
        {
            Success();

            OutputStream.WriteLine("Item: " + index);
        }
    }
}