using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorni
{
    internal class task6
    {
        public static void SixthTask()
        {
            double CircleArea(double r)
            {
                return Math.PI * r * r;
            }

            double RectangleArea(double a, double b)
            {
                return a * b;
            }

            double CubeVolume(double a)
            {
                return a * a * a;
            }



            Console.WriteLine(CircleArea(5));
            Console.WriteLine(RectangleArea(12, 5));
            Console.WriteLine(CubeVolume(19));
        }
        
    }
}
