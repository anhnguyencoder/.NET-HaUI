using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for(int i = 1; i <= n; i++)
            {
                ans += i;

            }
            double ans2 = 0;
            Console.WriteLine($"S= {ans}");
            for (int i = 1; i <= n; i++)
            {
                ans2+= (double)1/i;

            }
            Console.WriteLine($"S2= {ans2}");
        }
    }
}
