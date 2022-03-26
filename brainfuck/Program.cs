using System.IO;
using System;

namespace BrainFuck
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (File.Exists(args[0]))
            {
                Interpreter interpreter = new Interpreter();
                interpreter.BuildAndRun(File.ReadAllText(args[0]));
            }
            else if (args[0] == "--version")
                Console.WriteLine("C# BrainFuck Interpreter 1.0 by https://github.com/biscuitaulait.");
            else
                Console.WriteLine($"File \"{args[0]}\" has not exists.");
        }
    }
}