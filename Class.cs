using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Class
    {
    }
    public class Circle
    {
        public Circle(int radius)
        {
            this.radius = radius;

        }
        public int radius { get; private set; }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double Omkrets()
        { 
            return 2 * radius * Math.PI;
        }
        public double Volym()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        }

    }
    public class Triangel
    {
        public Triangel(int hy, double katetA, double katetB)
        {
            this.hy = hy;
            this.katetA = katetA;
            this.katetB = katetB;
        }

        public int hy { get; set; }
        public double katetA { get; set; }
        public double katetB { get; set; }
        public double Area()
        {
            return (katetA * katetB) / 2;
        }

    }
    
}
