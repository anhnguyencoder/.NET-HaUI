using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu cua mang: ");
            int n;
          
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 100)
            {
                Console.WriteLine("Vui long nhap so nguyen duong tu 1 den 100.");
            }

           
            List<int> numbers = new List<int>();
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                int num;
                Console.Write($"Phan tu {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Vui long nhap mot so nguyen.");
                    Console.Write($"Phan tu {i + 1}: ");
                }
                numbers.Add(num);
            }

            // Tinh tong cac phan tu chan
            int sumEven = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
            }
            Console.WriteLine($"Tong cac phan tu chan: {sumEven}");

            // Sap xep List tang dan
            numbers.Sort();

            // In List sau khi sap xep
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }
    }
}
