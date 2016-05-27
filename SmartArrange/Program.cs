namespace IcerSystem.FileArrange
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
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

            try
            {
                var sa = new SmartArrange();
                sa.Arrange(names.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}