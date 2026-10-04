using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Enemy
    {
        public int x; 
        public int y;
        public char enemySymbol;

        public void move(int xPosition, int yPosition)
        {
            x = xPosition;
            y = yPosition;
        }

    }
    class Player
    {
        public int x;
        public char playerSymbol;
        public int y;

        public Player(int x1, int y1,  char symbol)
        {
            x = x1;
            y = y1;
            playerSymbol = symbol;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(3, 5, '@');

            Enemy e1 = new Enemy();
            e1.x = 2;
            e1.y = 4;
            e1.enemySymbol = '$';
            e1.move(6, 8);
            Console.WriteLine(e1.x);
            Console.WriteLine(e1.y);

            Enemy e2 = new Enemy();
            e2.x = 3;
            e2.y = 5;
            e2.enemySymbol = '#';
            e2.move(7, 9);
            Console.WriteLine(e2.x);
            Console.WriteLine(e2.y);

        }
    }
}
