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
            Figure king = null;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("  Create King - K");
                Console.WriteLine("  Try Move    - M x1 y1");
                Console.WriteLine("  Exit        - X");
                choose = Console.ReadLine().ToUpper();
                string[] subs = choose.Split(' ');
                switch (subs[0])
                {
                    case "K": 
                        king = FigureFabric.Make("King", 1, 1);
                        Console.WriteLine("The king is created. Make a move");
                        break;
                    case "M":
                        try {
                            Console.WriteLine(king.Move(int.Parse(subs[1]), int.Parse(subs[2])));
                        }
                        catch {
                            //ignore
                        }
                        break;
                    case "X": return;
                }
            }
        }
    }
}
