using System;
using System.Collections.Generic;
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
            var packages = repo.FindPackagesById(id).ToList();
            packages = packages.Where(item => (item.IsReleaseVersion() && item.Tags.Contains("wman"))).ToList();

            string path = Man.ManFolder + packages.FirstOrDefault();
            var packageManager = new PackageManager(repo, path);

            //Download and unzip the package
            packageManager.InstallPackage(id, SemanticVersion.Parse("5.0.0"));
        }
    }
}