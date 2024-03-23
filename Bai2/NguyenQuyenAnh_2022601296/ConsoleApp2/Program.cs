using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Nhap(out a, out b, out c);
            Giai(a, b, c);
        }

        static void Nhap(out double a, out double b, out double c)
        {
            Console.WriteLine("nhap cac he so cua pt:");
            Console.Write("nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("nhap c: ");
            c = double.Parse(Console.ReadLine());
        }

        static void Giai(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("pt vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("pt co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("pt co hai nghiem phan biet:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
