using System;
using System.IO;
using System.Linq;

namespace SearchAWord
{
    class Program
    {

        // -c -i

        static void Main(string[] args)
        {
            bool kontrolovatVelikost = false;
            if (args.Length > 0)
            {
                kontrolovatVelikost = (args[0] == "-c");
            }

            


            var lines = File.ReadAllLines(@"D:\Jakub\Desktop\polda7.txt");


            int lineNumber = 1;
            while (true)
            {
                var searchWord = Console.ReadLine();

                foreach (string line in lines)
                {
                    if (line.IndexOf(searchWord) != -1)
                    {
                        lineNumber = line.IndexOf(searchWord);
                        Console.WriteLine("  {1}", line.Substring());
                        Console.WriteLine(searchWord);
                    }
                  
                  lineNumber++;

                }
                lineNumber = 1;
            }
        }
    }
}
