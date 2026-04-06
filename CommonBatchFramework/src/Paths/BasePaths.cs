using System;
using System.IO;

namespace CommonBatchFramework.Paths
{
    public abstract class BasePaths
    {
        protected readonly string BaseDir;

        protected BasePaths()
        {
            BaseDir = AppContext.BaseDirectory;
        }

        public string OutputDir => Path.Combine(BaseDir, "Output");

        public void EnsureDirectories()
        {
            Directory.CreateDirectory(OutputDir);
        }
    }
}