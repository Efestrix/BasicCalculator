// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



var slova = File.ReadAllLines(@"D:\Jakub\Desktop\english-nouns.txt");

// foreach(var slovo in slova)
// {
//   Console.WriteLine(slovo);
// }

var rnd = new Random();
var rn = rnd.Next(0, slova.Count()-1);
var rw = slova[rn];
var hidden = new String('_', rw.Length);
Console.WriteLine(rw);

// if (rw.Contains(vstup_od_uzivatele)) { // nahrad '_' skutecnym pismenem }
//rw.Substring()

while (true)
{
  // 1. zjisit zda slovo je uhodnute cele a nebo byl dosazen maximum pokusu (pokud ano konec -> break)

  // 2. vypsat hadane slovo ve formatu _ _ _ _ _

  // 3. vyzvat hrace k zadani pismene

  // 4. vyhodnotit vstup od hrace, tzn. zjistit zda pismeno je obsazeno ve slove a nahradit podtrzitko pismenem
  // 4b. pokud neexistuje navys aktualni pocet pokusu
}
//Console.WriteLine(rn);
