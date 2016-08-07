namespace wman
{
    class Program
    {
        //wman cpp 3 cout
        //wman install cpp
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "install")
                {
                    PackageInstaller.Install(args[1]);
                }
                else
                {
                    PageViewer.Show(args);
                }
            }
        }
    }
}