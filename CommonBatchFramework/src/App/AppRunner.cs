using System;

namespace CommonBatchFramework.App
{
    public static class AppRunner
    {
        public static void Run(Action action)
        {
            try
            {
                action();

                Console.WriteLine("正常終了しました。");
            }
            catch (Exception ex)
            {
                Console.WriteLine("エラーが発生しました:");
                Console.WriteLine(ex.ToString());

                Environment.ExitCode = 1;
            }

            Console.WriteLine("Enterキーで終了...");
            Console.ReadLine();
        }
    }
}