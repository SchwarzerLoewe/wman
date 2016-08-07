using System.IO;
using NuGet;

namespace wman_Builder
{
    public static class PackagePublisher
    {
        public static void Publish(string apiKey, IPackage pkg, long size)
        {
            var ps = new PackageServer("https://packages.nuget.org/api/v2", "wman/1.0 -pre");
            ps.PushPackage(apiKey, pkg, size, 1800, false);
        }

        public static IPackage CreatePackage()
        {
            ManifestMetadata metadata = new ManifestMetadata()
            {
                Authors = "mauvo",
                Version = "1.0.0.0",
                Id = "myPackageIdentifier",
                Description = "A description",
            };

            PackageBuilder builder = new PackageBuilder();
            builder.PopulateFiles("folderPath/", new[] { new ManifestFile() { Source = "**" } });
            builder.Populate(metadata);
            
            using (FileStream stream = File.Open(packagePath, FileMode.OpenOrCreate))
            {
                builder.Save(stream);
            }
            PackageHelper.ResolvePackage()
        }
    }
}