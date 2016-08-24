using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static string ManFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\wman\\";

        public List<PageItem> Items { get; set; } = new List<PageItem>();
        
        public static Man Load(string path) => (Man)XamlServices.Load(path);

        public void Save(string path)
        {
            var xaml = XamlServices.Save(this);
            File.WriteAllText(path, xaml);
        }
    }

    public class PageItem
    {
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public string SeeAlso { get; set; }
        public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Name: ");
            Console.ResetColor();
            Console.WriteLine(Name);
            Console.WriteLine();

            if (Description != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Description:");
                Console.ResetColor();
                Console.WriteLine(Description);
                Console.WriteLine();
            }

            if (Example != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Example:");
                Console.ResetColor();
                Colorizer.ColorString(Example, '"', Color.DarkSalmon);
                Console.WriteLine();
            }
            if (Synopsis != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Synopsis:");
                Console.ResetColor();
                Console.WriteLine(Synopsis);
                Console.WriteLine();
            }
            if (SeeAlso != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("See Also:");
                Console.ResetColor();
                Console.WriteLine(SeeAlso);
                Console.WriteLine();
            }
            if (Properties.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Properties:");
                Console.ResetColor();

                foreach (var property in Properties)
                {
                    Console.WriteLine(property.Key + ": " + property.Value);
                }
            }
        }
    }
}