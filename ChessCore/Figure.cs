using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCore
{
    public class Figure
    {
        protected int x, y;
        public string name;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
            name = "";
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    public class King : Figure
    {
        public King(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "King";
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
        }
    }

    public class Queen : Figure
    {
        public Queen(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "Queen";
        }

        public override bool Move(int newX, int newY)
        {
            return (x == newX || y == newY || Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }

    public class Bishop : Figure
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "Bishop";
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }

    public class Knight : Figure
    {
        public Knight(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "Knight";
        }

        public override bool Move(int newX, int newY)
        {
            return ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) || (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2));
        }
    }

    public class Rook : Figure
    {
        public Rook(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "Rook";
        }

        public override bool Move(int newX, int newY)
        {
            return (x == newX || y == newY);
        }
    }

    public class Pawn : Figure
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
            name = "Pawn";
        }

        public override bool Move(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) || (x == newX && y + 1 == newY));
        }
    }
}
