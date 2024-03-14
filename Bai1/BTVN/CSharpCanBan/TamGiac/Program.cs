using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("nhap b ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("nhap c ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi cua tam giac la = "+(a+b+c));
            double p = (a + b + c) / 2;
            Console.WriteLine("dien tich hinh tam giac la = " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));



        }
    }
}
