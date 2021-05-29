using System;
using System.Collections.Generic;
using ChessCore;

namespace Сhess
{
    class Program
    {
        static public List<Figure> figures;

        static void Main(string[] args)
        {
            string choose;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("     King's   Move  - K");
                Console.WriteLine("     Queen's  Move  - Q");
                Console.WriteLine("     Bishop's Move  - B");
                Console.WriteLine("     Knight's Move  - KN");
                Console.WriteLine("     Rook's   Move  - R");
                Console.WriteLine("     Pawn's   Move  - P");
                Console.WriteLine("     Exit           - X");
                choose = Console.ReadLine().ToUpper();
                switch (choose)
                {
                    case "K":  break;
                    case "Q": break;
                    case "B": break;
                    case "KN": break;
                    case "R": break;
                    case "P": break;
                    case "X": return;
                }
            }
        }

        //static public void AddKing()
        //{
        //    King k = new King(1, 1);
        //    figures.Add(k);
        //}
    }
}
