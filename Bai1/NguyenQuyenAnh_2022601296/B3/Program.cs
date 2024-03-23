using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap thang (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("nhap nam:");
            int year = Convert.ToInt32(Console.ReadLine());

            int numberOfDays = GetNumberOfDaysInMonth(month, year);
            Console.WriteLine("so ngay cua thang {0} nam {1} là: {2}", month, year, numberOfDays);
        }

        static int GetNumberOfDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return -1; // Trả về -1 nếu tháng nhập không hợp lệ
            }
        }

        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
