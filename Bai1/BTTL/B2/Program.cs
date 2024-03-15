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
            Console.WriteLine("Nhập chiều dài hình chữ nhật:");
            double chieuDai = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng hình chữ nhật:");
            double chieuRong = Convert.ToDouble(Console.ReadLine());

            double chuVi = 2 * (chieuDai + chieuRong);
            double dienTich = chieuDai * chieuRong;

            Console.WriteLine($"Chu vi của hình chữ nhật là: {chuVi}");
            Console.WriteLine($"Diện tích của hình chữ nhật là: {dienTich}");
        }
    }
}
