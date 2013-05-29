using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IcerSystem.FileArrange
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("One filename argument expected!");
            }
            var filename = args[0];
            if (!File.Exists(filename))
            {
                Console.WriteLine("The file you specified is not exist!");
            }
            var names = new List<string>();
            using (StreamReader tr = new StreamReader(filename, Encoding.Default))
            {
                while (!tr.EndOfStream)
                {
                    var line = tr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        names.Add(line);
                }
            }
            string result = SmartArrange.Arrange(names.ToArray());

        }
    }
}
