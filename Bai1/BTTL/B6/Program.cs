using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
            do
            {
                Console.WriteLine("Nhập một số nguyên:");
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            Console.WriteLine($"Số nguyên dương nhận được là: {so}");
        }
    }
}
