using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    continue; // Bỏ qua các số chia hết cho 5
                }
                Console.WriteLine(i);
            }
        }
    }
}
