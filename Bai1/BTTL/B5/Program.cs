using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số từ 1 đến 7:");
            int so = Convert.ToInt32(Console.ReadLine());

            switch (so)
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ hai");
                    break;
                case 3:
                    Console.WriteLine("Thứ ba");
                    break;
                case 4:
                    Console.WriteLine("Thứ tư");
                    break;
                case 5:
                    Console.WriteLine("Thứ năm");
                    break;
                case 6:
                    Console.WriteLine("Thứ sáu");
                    break;
                case 7:
                    Console.WriteLine("Thứ bảy");
                    break;
                default:
                    Console.WriteLine("Số không hợp lệ.");
                    break;
            }
        }
    }
}
