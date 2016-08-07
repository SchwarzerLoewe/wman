using System.IO;
using NuGet;
using wman.Core;

namespace wman_Builder
{
    public static class PackagePublisher
    {
        public static void Publish(string apiKey, IPackage pkg, long size)
        {
            var ps = new PackageServer("https://packages.nuget.org/api/v2", "wman/1.0 -pre");
            ps.PushPackage(apiKey, pkg, size, 1800, false);
        }

        public static void CreatePackage(string path, ManifestMetadata metadata, Man man)
        {
            PackageBuilder builder = new PackageBuilder();
            builder.Populate(metadata);

            var tmpFile = Path.GetTempFileName();
            man.Save(tmpFile);

            builder.Files.Add(new PhysicalPackageFile {SourcePath = tmpFile});

            using (FileStream stream = File.Open(path, FileMode.OpenOrCreate))
            {
                builder.Save(stream);
            }
        }
    }
}