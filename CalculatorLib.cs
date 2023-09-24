using CalculatorLib;


//BASIC CALCULATOR
var calc = new BasicCalculator();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("BASIC CALCULATOR");
Console.WriteLine();
Console.WriteLine("5 + 2  = " + calc.Addition(5, 2));
Console.WriteLine("5 - 2  = " + calc.Substriction(5, 2));
Console.WriteLine("5 * 2  = " + calc.Multiplication(5, 2));
Console.WriteLine("6 / 2  = " + calc.Division(6, 2));
Console.WriteLine("6 / 0  = " + calc.Division(6, 0));
Console.WriteLine("NEG(5)  = " + calc.Negation(5));

//SaveToMemory - ulozeni do pameti, 1 parametr
Console.WriteLine("SaveToMemory(10): " + calc.SaveToMemory(10));
//ReadFromMemory - nacteni z pameti, vraci obsah pameti
Console.WriteLine("ReadFromMemory: " + calc.ReadFromMemory());
//AddToMemory - pricte hodnotu k hodnote v pameti a opet ulozi do pameti, 1 parametr
Console.WriteLine("AddToMemory(5): " + calc.AddToMemory(5));
//DeleteMemory - vymaze pamet, tj. nastavi na 0
Console.WriteLine("DeleteMemory: " + calc.DeleteMemory());


Console.WriteLine();
//BASIC CALCULATOR WITH HISTORY
var calcWithHistory = new CalculatorWithHistory();
Console.WriteLine("BASIC CALCULATOR WITH HISTORY");
Console.WriteLine();
calcWithHistory.AdditionWithHistory(5, 1);
calcWithHistory.AdditionWithHistory(5, 2);
calcWithHistory.AdditionWithHistory(5, 3);
calcWithHistory.PrintHistory();


string[] mojePole = new ArrayBasics(new string[] { "Kuba", "Mojmir", "Roman", "Filip", "Honza", "Pepa" });
