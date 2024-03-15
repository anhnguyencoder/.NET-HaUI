using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập độ chính xác epsilon:");
            double epsilon = Convert.ToDouble(Console.ReadLine());

            double guess = 1; // Xác định giá trị đầu tiên của x(0)
            double previousGuess; // Lưu trữ giá trị của x(n-1)

            do
            {
                previousGuess = guess;
                guess = (a / previousGuess + previousGuess) / 2; // Cập nhật giá trị của x(n)
            } while (Math.Abs(guess - previousGuess) > epsilon); // Lặp cho đến khi độ chính xác đạt được

            Console.WriteLine($"Căn bậc 2 của {a} là: {guess}");
        }
    }
}
