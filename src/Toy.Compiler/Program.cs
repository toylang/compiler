using System;
using System.Text.Json;

namespace Toy.Compiler
{
    public class Program
    {
        static int Main(string[] args)
        {
            var arguments = ParseArgument(args);
            Console.WriteLine(JsonSerializer.Serialize(arguments));
            return Toyc.Run(arguments);
        }

        public static Argument ParseArgument(string[] args)
        {
            var arguments = new Argument();
            for (var i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-sf":
                        arguments.SourceFile = args[++i];
                        break;
                }
            }
            return arguments;
        }
    }
}
