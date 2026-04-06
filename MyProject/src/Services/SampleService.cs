using System;
using System.IO;

namespace MyProject.Services
{
    public class SampleService
    {
        public void Execute(GlobalPaths paths)
        {
            Console.WriteLine("処理開始");

            Console.WriteLine($"InputDir: {paths.InputDir}");
            Console.WriteLine($"OutputDir: {paths.OutputDir}");

            // テスト用：Outputにファイル作成
            var filePath = Path.Combine(paths.OutputDir, "test.txt");

            File.WriteAllText(filePath, "Hello World");

            Console.WriteLine("ファイル作成完了");
        }
    }
}