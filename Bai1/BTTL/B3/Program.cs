using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập hệ số a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Nghiệm của phương trình là: {x}");
            }
        }
    }
}
