using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class caub
    {
        public static void main()
        {
            Console.WriteLine("Nhập hệ số a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }
    }
}
