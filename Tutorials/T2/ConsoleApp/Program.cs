using System;

namespace RunDebugConfigTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = args.Length > 0 && args[0] == "DE" ? "Hallo Welt!" : "Hello World!";
            Console.WriteLine(text);
        }
    }
}