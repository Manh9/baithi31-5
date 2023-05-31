using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the cylinder:");
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();

            Console.ReadLine();
        }
    }
}
