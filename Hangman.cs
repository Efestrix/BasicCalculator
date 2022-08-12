using System;
using System.IO;

namespace Hangman
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman");

            var rnd = new Random();
            var slova = File.ReadAllLines(@"D:\Jakub\Desktop\english-nouns.txt");
            var rn = rnd.Next(0, slova.Count() - 1);
            var hadaneSlovo = slova[rn];
            var hidden = new List<char>(new String('_', hadaneSlovo.Length)); // _ _ _ a _ _ _

            var guessedLetters = new List<char>();
            var pocetNeuspesnychPokusu = 0;

            while (true)
            {
                var odkryteSlovo = String.Join(" ", hidden);
                Console.WriteLine(odkryteSlovo);
                Console.WriteLine("Please enter a letter: ");
                string vstup = Console.ReadLine();
                char zadanePismeno = vstup[0]; // 'a
                guessedLetters.Add(zadanePismeno);

                var i = 0;
                bool uhadlPismeno = false;
                foreach (char aktualniPismeno in hadaneSlovo) //letadlo
                {

                    // 4. let[a]dlo
                    if (zadanePismeno == aktualniPismeno)
                    {
                        // 4. _ _ _ _ _ _ _ -> _ _ _ a _ _ _
                        hidden[i] = zadanePismeno;
                        uhadlPismeno = true;
                    }

                    i++;
                }


                bool celeSlovoUhadnute = true;
                foreach (char aktualniPismeno in hidden)
                {
                    if (aktualniPismeno == '_')
                    {
                        celeSlovoUhadnute = false;
                        break;
                    }
                }
                if (celeSlovoUhadnute)
                {
                    break;
                }

                if (!uhadlPismeno)
                {
                    pocetNeuspesnychPokusu++;
                }

                if (pocetNeuspesnychPokusu > 5)
                {
                    break;
                }


            }
            Console.WriteLine(hadaneSlovo);

        }
    }
}



// foreach(var slovo in slova)
// {
//   Console.WriteLine(slovo);
// }


// if (rw.Contains(vstup_od_uzivatele)) { // nahrad '_' skutecnym pismenem }
//rw.Substring()


// 1. zjisit zda slovo je uhodnute cele a nebo byl dosazen maximum pokusu (pokud ano konec -> break)

// 2. vypsat hadane slovo ve formatu _ _ _ _ _

// 3. vyzvat hrace k zadani pismene


// 4. vyhodnotit vstup od hrace, tzn. zjistit zda pismeno je obsazeno ve slove a nahradit podtrzitko pismenem
// 4b. pokud neexistuje navys aktualni pocet pokusu

//Console.WriteLine(rn);