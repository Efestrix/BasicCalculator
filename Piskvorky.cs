using System;

namespace Piskvorky
{
    class Piskvorky
    {

        public static bool IsWinner(char[,] playground, char player)
        {
            // zjisti jestli player vyhral!
            //1. zkontroluj zda radek 1 obsahuje ‘X’ 3x
            if (playground[0, 0] == player && playground[0, 1] == player && playground[0, 2] == player) return true;
            //2. zkontroluj zda radek 2 obsahuje ‘X’ 3x
            if (playground[1, 0] == player && playground[1, 1] == player && playground[1, 2] == player) return true;
            //3. zkontroluj zda radek 3 obsahuje ‘X’ 3x
            if (playground[2, 0] == player && playground[2, 1] == player && playground[2, 2] == player) return true;
            //4. zkontroluj zda sloupec 1 obsahuje ‘X’ 3x
            if (playground[0, 0] == player && playground[1, 0] == player && playground[2, 0] == player) return true;
            //5. zkontroluj zda sloupec 2 obsahuje ‘X’ 3x
            if (playground[0, 1] == player && playground[1, 1] == player && playground[2, 1] == player) return true;
            //6. zkontroluj zda sloupec 3 obsahuje ‘X’ 3x
            if (playground[0, 2] == player && playground[1, 2] == player && playground[2, 2] == player) return true;
            //7. zkontroluj zda diagonala ([0,2], [1, 1], [2, 0]) obsahuje ‘X’ 3x
            if (playground[0, 2] == player && playground[1, 1] == player && playground[2, 0] == player) return true;
            //8. zkontroluj zda diagonala ([0, 0], [1, 1], [2, 2])
            if (playground[0, 0] == player && playground[1, 1] == player && playground[2, 2] == player) return true;


            return false;
        }

        public static void DisplayPlayground(char[,] playground)
        {
            for (int r = 0; r < 3; r++)
            {
                Console.Write("| ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(playground[r, c]);
                }
                Console.WriteLine();
            }
            
           return;
        }

        public static void Main(string[] args)
        {

            char player1 = 'X';
            char player2 = 'O';
            char tah = player1;
            char[,] playground = new char[3, 3]{
            {'#', '#', '#'},
            {'#', '#', '#'},
            {'#', '#', '#'}
            };

            while (true) //gameloop
            {

                Console.WriteLine("Zadejte prosím řádek:");
                string? rowRaw = Console.ReadLine(); //"1"
                int row = Convert.ToInt32(rowRaw); // "1" -> 1 // if (row == 1) row = 0 554 443
                row--;

                Console.WriteLine("Zadejte prosím sloupec:");
                string? colRaw = Console.ReadLine();
                int col = Convert.ToInt32(colRaw);
                col--;

                playground[row, col] = tah;

                //Console.WriteLine("radek:" + row + " sloupec:" + col);

                // ['A', 'B', 'C' ] = 1D pole

                // [['A', 'B'], ['C', 'D'], ['E', 'F']]
                //   01
                // 0 AB
                // 1 CD
                // 2 EF

                DisplayPlayground(playground);

                if (IsWinner(playground, tah))
                {
                    break;
                }

                if (tah == player1)
                {
                    tah = player2;
                }
                else
                {
                    tah = player1;
                }

            }
        }
    }
}