using System;
using System.Linq;
using NuGet;
using wman.Core;

namespace wman
{
    public static class PackageInstaller
    {
        public static void Install(string id)
        {
            var repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");

            Console.WriteLine("Searching for Packages...");
            var packages = repo.FindPackagesById(id)
                           .Where(item => (item.IsReleaseVersion() && item.Tags.Contains("wman"))).ToList();
            Console.WriteLine(packages.Count > 0 ? "Found Package" : "Cant find Package");

            string path = Man.ManFolder;
            var packageManager = new PackageManager(repo, path);

            //Download and unzip the package
            Console.WriteLine("Installing Package");
            try
            {
                packageManager.InstallPackage(packages.FirstOrDefault()?.Id, null);
                Console.WriteLine("Package Installed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}