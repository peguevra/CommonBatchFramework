using System;
using System.IO;

namespace CommonBatchFramework.App
{
    public static class Log
    {
        private static string? logFile;

        public static void Initialize(string outputDir)
        {
            logFile = Path.Combine(outputDir, "log.txt");
        }

        public static void Info(string message)
        {
            Write($"[{Now()}] {message}");
        }

        public static void Error(string message)
        {
            Write($"[{Now()}] ERROR: {message}");
        }

        private static void Write(string message)
        {
            Console.WriteLine(message);

            if (!string.IsNullOrEmpty(logFile))
            {
                File.AppendAllText(logFile, message + Environment.NewLine);
            }
        }

        private static string Now()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}