using System;
using System.IO;

namespace SearchAWord
{
    class Program
    {

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"D:\Jakub\Desktop\english-nouns.txt");

            bool search = false;
            int lineNumber = 1;
            while (true)
            {
                string searchWord = Console.ReadLine();
                foreach (string line in lines)

                {
                    if (line.Contains(searchWord))
                    {
                        Console.WriteLine($"{lineNumber} -> {line}");
                    }
                    lineNumber++;

                }
                lineNumber = 1;
            }
            
        }
    }
}
    


