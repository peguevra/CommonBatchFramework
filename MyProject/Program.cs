using CommonBatchFramework.App;

namespace MyProject
{
    class Program
    {
        static void Main()
        {
            AppRunner.Run(() =>
            {
                var paths = new GlobalPaths();
                paths.EnsureDirectories();

                var service = new Services.SampleService();
                service.Execute(paths);
            });
        }
    }
}