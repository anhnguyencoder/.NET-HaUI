using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số nguyên n:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra n là số chẵn hay số lẻ
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{n} là số lẻ.");
            }

            // Kiểm tra n là số âm hay số không âm
            if (n >= 0)
            {
                Console.WriteLine($"{n} là số không âm.");
            }
            else
            {
                Console.WriteLine($"{n} là số âm.");
            }
        }
    }
}
