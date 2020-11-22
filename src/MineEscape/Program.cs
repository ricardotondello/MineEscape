using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entities;

namespace MineEscape
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args.Any() ? args[0] : "config.txt";
            
            string[] lines = ReadConfigFile(filePath);
            
            new MineScape(
                new ReadConfig(lines).Read(),
                new List<Result>()
                ).Play();
            Console.ReadLine();
        }

        private static string[] ReadConfigFile(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException("You must have a config file");
            return System.IO.File.ReadAllLines(@"" + path);
        }
    }
}
