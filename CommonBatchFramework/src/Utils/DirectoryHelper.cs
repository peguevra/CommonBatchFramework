using System.IO;

namespace CommonBatchFramework.Utils
{
    public static class DirectoryHelper
    {
        public static void Ensure(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}