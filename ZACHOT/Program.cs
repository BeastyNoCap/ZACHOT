using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZACHOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{GetZ (1, 2, 3, 4)}");
            Console.ReadKey();
        }
        public static double GetZ(double A, double B, double C, double D)
        {
            double max = 0;
            double min = 0;
            if (B>C)
            {
                max = B;
            }
            if (C>D+1)
            {
                max = C;
            }
            else
            {
                max = D + 1;
            }
            if (Math.Pow(A, 2)<max)
            {
                min = Math.Pow(A, 2);
            }
            else
            {
                min = max;
            }
            return min;
        }
    }
}
