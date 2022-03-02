namespace CalculatorLib;

//Implementuj tridu BasicCalculator, ktera bude obsahovat zakladni funkce (viz nize)
//Addition - 2 parametry a provede soucet, vrati vysledek
//Substraction - 2 parametry, odcitani, vrati vysledek
//Multiplication - 2 parametry, nasobeni, vrati vysledek
//Division - 2 parametry, deleni, vrati vysledek
//Negation - 1 parametr, vrati hodnotu s opacnym znamenkem
//Dale bude umoznovat zakladni praci s pameti
//do vlastnosti (property) si bude moci ulozit vysledek operace nebo jej nacist nebo vypsat
//SafeToMemory - ulozeni do pameti, 1 parametr
//ReadFromMemory - nacteni z pameti, vraci obsah pameti
//AddToMemory - pricte hodnotu k hodnote v pameti a opet ulozi do pameti, 1 parametr
//DeleteMemory - vymaze pamet, tj. nastavi na 0
public class BasicCalculator
{
    public BasicCalculator()
    {
    }
}

Console.WriteLine("Zadej operaci");
  char operace = Console.ReadLine()[0];

  Console.WriteLine("Zadej dvě čísla");
  int num1 = Convert.ToDouble(Console.ReadLine());
  int num2 = Convert.ToDouble(Console.ReadLine());

  int result =

  switch(operace)
  {
     // součet 
   case '+':
       Console.WriteLine("{0} + {1} = {2}",num1,num2,(num1+num2));
       break;

     // odčitání 
    case '-':
       Console.WriteLine("{0} - {1} = {2}",num1,num2,(num1-num2));
       break;
  
     // násobení
    case '*':
       Console.WriteLine("{0} * {1} = {2}",num1,num2,(num1*num2));
       break;

     // dělení
    case '/':
        if (num2 == 0.0)
            Console.WriteLine("Dělení s nulou");
        else 
            Console.WriteLine("{0} / {1} = {2}",num1,num2,(num1/num2));
        break;

    default:
         Console.WriteLine("{0} je neplatný operátor",op);
         break;

  {

  