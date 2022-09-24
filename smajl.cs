using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej smajlíka:");
            string smajl = Console.ReadLine();
            switch (smajl)
            {
                case ":-)":
                case ":)":
                    Console.WriteLine("Tvůj smajlík je veselý");
                    break;
                case ":-(":
                case ":(":
                    Console.WriteLine("Tvůj smajlík je smutný");
                    break;
                case ":-*":
                case ":*":
                    Console.WriteLine("Tvůj smajlík je zamilovaný");
                    break;
                case ":-P":
                case ":P":
                    Console.WriteLine("Tvůj smajlík je s vyplazeným jazykem");
                    break;
                default:
                    Console.WriteLine("Tvůj smajlík je neznámý");
                    break;
            
            }

        }
    }
}
