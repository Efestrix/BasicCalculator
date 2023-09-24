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
public class BasicCalculator : ICalculator
{
    private int _memory = 0;

    public int Memory
    {
        get {return _memory;}
        set {_memory = value;}
    }

    //Addition - 2 parametry a provede soucet, vrati vysledek
    public int Addition(int number1, int number2)
    {
        return number1 + number2;
    }

    //Substraction - 2 parametry, odcitani, vrati vysledek
    public int Substriction(int number1, int number2)
    {
        return number1 - number2;
    }
    
    //Multiplication - 2 parametry, nasobeni, vrati vysledek
    public int Multiplication(int number1, int number2)
    {
        return number1 * number2;
    }

    //Division - 2 parametry, deleni, vrati vysledek
    public int Division(int number1, int number2)
    {
        if  (number2 == 0)
            //TODO: zde by mela byt vyhozena vyjimka, ale zatim neumime
            return 0;
        else
            return number1 / number2;
    }

    //Negation - 1 parametr, vrati hodnotu s opacnym znamenkem
    public int Negation(int number1)
    {
        return -number1;
    }

    //SaveToMemory - ulozeni do pameti, 1 parametr
    public int SaveToMemory(int number1)
    {
        Memory = number1;
        return Memory;
    }

    //ReadFromMemory - nacteni z pameti, vraci obsah pameti
    public int ReadFromMemory()
    {
        return Memory;
    }

    //AddToMemory - pricte hodnotu k hodnote v pameti a opet ulozi do pameti, 1 parametr
    public int AddToMemory(int number)
    {
       /* 
       Memory = Memory + number;
        return Memory;
        */

        return SaveToMemory(Addition(Memory,number));
    }

    
    

    //DeleteMemory - vymaze pamet, tj. nastavi na 0
    public int DeleteMemory()
    {
        /*
        Memory = 0;
        return Memory;
        */

        return SaveToMemory(0);
    }

}
  
