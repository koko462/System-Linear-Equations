using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfLinearEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[2, 3];
            double[] firstLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < 3; i++)
            {
                a[0, i] = firstLine[i];
                a[1, i] = secondLine[i];
            }

            double x2 = (a[0, 0] * a[1, 2] - a[1, 0] * a[0, 2]) / (a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0]);
            double x1 = (a[0, 2] - a[0, 1] * x2) / a[0, 0];

            Console.WriteLine("x1 => " + x1);
            Console.WriteLine("x2 => " + x2);
        }
    }
}
