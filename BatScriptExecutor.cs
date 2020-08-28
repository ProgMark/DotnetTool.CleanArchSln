using System.Diagnostics;
using System;
using System.IO;

namespace DotnetTool.CleanArchSln
{
    public class BatScriptExecutor
    {
        public void Execute(string arg)
        {
            var process = new Process();
            var startinfo = new ProcessStartInfo(@"run.bat", arg);
            startinfo.RedirectStandardOutput = true;
            startinfo.UseShellExecute = false;
            process.StartInfo = startinfo;
            process.OutputDataReceived += (sender, argsx) => Console.WriteLine(argsx.Data);
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            File.Delete("run.bat");
        }
    }
}