using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTest.com.m2i.formation.geometry
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void deplacer(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }

        public void afficher()
        {
            Console.WriteLine("(" + X + "," + Y + ")");
        }
    }
}
