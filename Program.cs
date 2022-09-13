using System;

// 1. vygeneruj nahodn cislo od 1 do 100
// 2. pozadej hrace o zadani cislo v tomto rozsahu
// 3. porovnej zadane cislo s hadanym cislem
// 4. a) pokud se neshoduje porad hraci zda nahdane cislo je vyssi/nizsi
//    b) pokud se shoduje, tak konec

// BONUS: omezit maximalni pocet pokusu (<5)

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 101);
            
            Console.WriteLine("Vítej v Guessing Game");
            Console.WriteLine("Náhodné číslo od 1 do 100 je vygenerovaný");
            Console.WriteLine("Pokud uhádneš náhodné číslo, vyhrál si");

           Console.WriteLine(randomNum);

           while (!isCorrectGuess)
           {
              Console.WriteLine("Zkus uhádnout náhodné číslo");
              int guess = Convert.ToInt32(Console.ReadLine());

              if (guess > randomNum)
              {
                 Console.WriteLine("Tvoje číslo je moc veliké");
              }
              else if(guess < randomNum)
              {
                 Console.WriteLine("Tvoje číslo je moc malé");
              }
              else
              {
                 Console.WriteLine("Uhádl si náhodné číslo");
                 isCorrectGuess = true;
              }
           }

           Console.WriteLine("Gratuluji, výhra si tuhle GuessingGame!");

           Console.ReadKey();
        }

    }

}
