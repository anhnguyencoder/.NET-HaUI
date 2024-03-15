using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số nguyên dương n (0 < n <= 100):");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0 && n <= 100)
            {
                int sum1 = CalculateSumUsingWhile(n);
                int sum2 = CalculateSumUsingDoWhile(n);
                int sum3 = CalculateSumUsingFor(n);

                Console.WriteLine("Tổng S (sử dụng while): " + sum1);
                Console.WriteLine("Tổng S (sử dụng do...while): " + sum2);
                Console.WriteLine("Tổng S (sử dụng for): " + sum3);
            }
            else
            {
                Console.WriteLine("Số n không hợp lệ.");
            }
        }

        static int CalculateSumUsingWhile(int n)
        {
            int sum = 0;
            int i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            return sum;
        }

        static int CalculateSumUsingDoWhile(int n)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i;
                i++;
            }
            while (i <= n);
            return sum;
        }

        static int CalculateSumUsingFor(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
