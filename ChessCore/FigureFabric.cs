using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    static public class FigureFabric
    {
        public static Figure Make(string name ,int x1, int y1)
        {
            Figure f = null;

            switch(name)
            {
                case "":
                    break;
                case "King":
                    f = new King(x1, y1);
                    break;
                case "Queen":
                    f = new Queen(x1, y1);
                    break;
                case "Bishop":
                    f = new Bishop(x1, y1);
                    break;
                case "Knight":
                    f = new Knight(x1, y1);
                    break;
                case "Rook":
                    f = new Rook(x1, y1);
                    break;
                case "Pawn":
                    f = new Pawn(x1, y1);
                    break;
            }

            return f;
        }
    }
}
