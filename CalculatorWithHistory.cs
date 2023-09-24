namespace CalculatorLib;

/// Implementuj kalkulacku, ktera je potomkem kalkulacky BasicCalculator.
/// Cilem teto kalkulacky oproti BasicCalculator je u kazde operace ulozit 
/// operaci do historie. Pro zacatek staci ukladat operace jen jako text do 
/// serazene do listu (List<string>). Nakonec pridat funkci, ktera historii 
/// vypise do Stdout (Console.WriteLine), nejak nasledovne:
/// 1. 4 + 3 = 7
/// 2. 2 * 89 = 178
/// 3. ...
public class CalculatorWithHistory : BasicCalculator
{
    private List<string> _history;

    public List<string> History
    {
        get {return _history;}
        set {_history = value;}
    }

    public CalculatorWithHistory()
    {
        _history = new List<string>();
    }


     //Addition - 2 parametry a provede soucet, vrati vysledek
    public int AdditionWithHistory(int number1, int number2)
    {
        int vysledek = Addition(number1, number2);
        History.Add(new String(number1.ToString() + " + " + number2.ToString() + " = " + vysledek.ToString()));
        
        return vysledek;
    }


    public void PrintHistory()
    {

        //Console.WriteLine(History.ToString());

        /*
        for (int i = 1; i<= History.Count; i++ )
        {
            Console.WriteLine(History[i-1].ToString());
        }
        */


        foreach (string item in History)
        {
            Console.WriteLine(item);
        }
        

        return;
    }

}
