using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle area = new Circle(5);
            Circle onearea = new Circle(6);
            Triangel twoarea = new Triangel(5, 5, 4);
            Console.WriteLine(area.GetArea());
            Console.WriteLine(onearea.GetArea());
            Console.WriteLine(area.Omkrets());
            Console.WriteLine(onearea.Omkrets());
            Console.WriteLine(area.Volym());
            Console.WriteLine(twoarea.Area());
        }
    }
}
