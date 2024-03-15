using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btth
{
    class Program
    {
        // Hàm tìm ước chung lớn nhất của hai số
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm rút gọn phân số và in kết quả
        static void SimplifyFraction(int m, int n)
        {
            // Tìm ước chung lớn nhất của m và n
            int gcd = FindGCD(m, n);

            // Rút gọn phân số
            m /= gcd;
            n /= gcd;

            // In ra màn hình phân số rút gọn
            Console.WriteLine("Phân số rút gọn của {0}/{1} là: {2}/{3}", m * Math.Sign(n), Math.Abs(n), m, Math.Abs(n));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào hai số nguyên m và n tương ứng với phân số m/n:");
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra nếu mẫu số n = 0
            if (n == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0.");
            }
            else
            {
                SimplifyFraction(m, n);
            }
        }
    }
}
