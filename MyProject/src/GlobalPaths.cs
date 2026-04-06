using System.IO;
using CommonBatchFramework.Paths;

namespace MyProject
{
    public class GlobalPaths : BasePaths
    {
        public string InputDir => Path.Combine(BaseDir, "Input");

        public string CodeFile => Path.Combine(BaseDir, "Code.xlsx");
    }
}