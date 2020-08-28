using System.IO;
using System.Linq;

namespace DotnetTool.CleanArchSln
{
    public class ReadmeFileCreator
    {
        public void Create()
        {
            var dirInfo = new DirectoryInfo(".");
            var isOk = dirInfo.GetFiles("Readme.md");
            if (!isOk.Any())
            {
                using (StreamWriter sw = File.CreateText(@"Readme.md"))
                {
                    sw.WriteLine("# Title");
                    sw.WriteLine("Description");
                    sw.WriteLine("# Changelog");
                    sw.WriteLine("| NugetVersion | Date | Change");
                    sw.WriteLine("| 1.0.0 | xxx | xxx");
                    sw.WriteLine("# Usage");
                    sw.WriteLine("## How to use description");
                }
            }
        }
    }
}