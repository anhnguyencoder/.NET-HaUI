using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap luong:");
            double luong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nhap thuong:");
            double thuong = Convert.ToDouble(Console.ReadLine());

            double thu_nhap = luong + thuong;
            double thue = 0;

            if (thu_nhap < 9000000)
            {
                thue = 0;
            }
            else if (thu_nhap >= 9000000 && thu_nhap <= 15000000)
            {
                thue = thu_nhap * 0.1;
            }
            else if (thu_nhap > 15000000 && thu_nhap <= 30000000)
            {
                thue = thu_nhap * 0.15;
            }
            else
            {
                thue = thu_nhap * 0.2;
            }

            Console.WriteLine("Thue thu nha la " + thue);
        }
    }
}
