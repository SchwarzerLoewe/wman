using System;
using System.IO;
using wman.Core;

namespace wman
{
    public static class PageViewer
    {
        public static void Show(string[] args)
        {
            var man = Man.Load(GetFileName(args[0]));

            foreach (var p in man.Items)
            {
                if (p.Name == args[1])
                {
                    p.Print();
                }
            }
        }

        private static string GetFileName(string id)
        {
            var files = Directory.GetFiles(Man.ManFolder, "*.wman", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if (Path.GetFileNameWithoutExtension(file) == id)
                {
                    return file;
                }
            }

            return id;
        }
    }
}