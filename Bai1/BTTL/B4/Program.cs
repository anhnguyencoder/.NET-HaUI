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
            Console.WriteLine("Nhập bậc lương:");
            int bacLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số ngày công:");
            int ngayCong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập phụ cấp:");
            int phuCap = Convert.ToInt32(Console.ReadLine());

            int nctl = (ngayCong < 25) ? ngayCong : 25 + (ngayCong - 25) * 2;
            double tienLinh = bacLuong * 1490000 * nctl + phuCap;

            Console.WriteLine($"Tiền thực lĩnh là: {tienLinh}");
        }
    }
}
