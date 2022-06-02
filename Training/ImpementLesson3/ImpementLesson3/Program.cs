using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpementLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point();

            //Access via properties
            Console.WriteLine("-------------------------Access via properties--------------------------");
            pt.x = 3;
            pt.y = 9;
            Console.WriteLine($"The X Points is: {pt.x} and the Y Point is: {pt.y}");

            //Access via method
            Console.WriteLine("\n-------------------------Access via method--------------------------");
            pt.SetLocation(5, 1);
            Console.WriteLine($"The X Points is: {pt.x} and the Y Point is: {pt.y}");
        }
    }
}
