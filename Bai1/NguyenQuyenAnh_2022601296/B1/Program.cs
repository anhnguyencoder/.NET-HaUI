using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nhap b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nhap c");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("phuong trinh co 2 nghiem phan biet");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("phuong trinh co nghiem kep");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
        }
    }
}
