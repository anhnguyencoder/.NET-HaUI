using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool laSoNguyenTo = true;

            if (n <= 1)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không là số nguyên tố.");
            }
        }
    }
}
