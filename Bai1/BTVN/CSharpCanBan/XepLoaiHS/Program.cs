using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap ho ten hs: ");
            string ten = Console.ReadLine();
            Console.Write("nhap diem: ");
            double diem = double.Parse(Console.ReadLine());
            if (diem >= 8)
            {
                Console.WriteLine(ten.ToUpper() + " loai Gioi");
            }
            else if(diem>=6.5 && diem > 8)
            {
                Console.WriteLine(ten.ToUpper() + " loai Kha");
            }else if(diem>=5 && diem < 6.5)
            {
                Console.WriteLine(ten.ToUpper() +" loai TB");
            }
            else
            {
                Console.WriteLine(ten.ToUpper() +"loai Yeu");
            }
        }
    }
}
