using wman.Core;

namespace wman
{
    public static class PageViewer
    {
        public static void Show(string[] args)
        {
            var page = int.Parse(args[1]);

#if !DEBUG
            var man = Man.Load(Man.ManFolder + "\\" + args[0] + ".wman");

            foreach (var p in man.Pages[page].Items)
            {
                if (p.Name == args[2])
                {
                    Console.WriteLine(p.ToString());
                }
            }
#else
            var m = new Man();
            var pa = new Page();
            var it = new PageItem
            {
                Name = "cout",
                Description = "Write something to console",
                Example = "std::cout << \"main function\" << std::endl;",
                SeeAlso = "http://en.cppreference.com/w/cpp/io/cout"
            };

            pa.Items.Add(it);
            m.Pages.Add(pa);

            foreach (var p in m.Pages[page].Items)
            {
                if (p.Name == args[2])
                {
                    p.Print();
                }
            }
#endif
        }
    }
}