using System;

namespace DotnetTool.CleanArchSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start creating solution in clean arch way");
            new BatScriptCreator().Create();
            new BatScriptExecutor().Execute(args[0]);
            new GitIgnoreFileCreator().Create();
            new DocsFolderCreator().Create();
            new ReadmeFileCreator().Create();
            Console.WriteLine("Solution created successfully");
        }
    }
}