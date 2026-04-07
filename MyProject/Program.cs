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

                Log.Initialize(paths.OutputDir); // ← これ追加

                var service = new Services.SampleService();
                service.Execute(paths);
            });
        }
    }
}