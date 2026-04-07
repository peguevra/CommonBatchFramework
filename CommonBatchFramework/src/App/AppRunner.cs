using System;

namespace CommonBatchFramework.App
{
    public static class AppRunner
    {
        public static void Run(Action action)
        {
            try
            {
                Log.Info("処理開始");

                action();

                Log.Info("正常終了しました。");
            }
            catch (Exception ex)
            {
                Log.Error("エラーが発生しました:");
                Log.Error(ex.ToString());

                Environment.ExitCode = 1;
            }

            Log.Info("Enterキーで終了...");
            Console.ReadLine();
        }
    }
}