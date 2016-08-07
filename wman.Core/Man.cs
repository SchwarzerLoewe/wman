using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Markup;
using System.Xaml;

[assembly: XmlnsDefinition("http://schwarzer-loewe.esy.es/schemas/wman", "wman")]
[assembly: XmlnsDefinition("http://schwarzer-loewe.esy.es/schemas/wman", "wman.Core")]

namespace wman.Core
{
    [ContentProperty("Pages")]
    public class Man
    {
        public string ManFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wman\\";

        public List<Page> Pages { get; set; } = new List<Page>();

        public static Man Load(string path)
        {
            return (Man)XamlServices.Load(path);
        }

        public void Save(string path)
        {
            var xaml = XamlServices.Save(this);
            File.WriteAllText(path, xaml);
        }
    }

    [ContentProperty("Items")]
    public class Page
    {
        public List<PageItem> Items { get; set; } = new List<PageItem>();
    }

    public class PageItem
    {
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string SeeAlso { get; set; }
    }
}