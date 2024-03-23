using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double chiSoDau = 0, chiSoCuoi = 0;

            // Gọi phương thức nhập
            Nhap(out chiSoDau, out chiSoCuoi);

            // Gọi phương thức TinhTien và hiển thị kết quả
            try
            {
                double tienDien = TinhTien(chiSoDau, chiSoCuoi);
                Console.WriteLine("So tien dien can thanh toan: " + tienDien.ToString("N0") + " dong");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Nhap(out double chiSoDau, out double chiSoCuoi)
        {
            Console.WriteLine("Nhap chi so dau va chi so cuoi:");
            Console.Write("Chi so dau: ");
            if (!double.TryParse(Console.ReadLine(), out chiSoDau))
            {
                throw new ArgumentException("Chi so dau khong dung dinh dang.");
            }

            Console.Write("Chi so cuoi: ");
            if (!double.TryParse(Console.ReadLine(), out chiSoCuoi))
            {
                throw new ArgumentException("Chi so cuoi khong dung dinh dang.");
            }
        }

        static double TinhTien(double chiSoDau, double chiSoCuoi)
        {
            const double GIA_100KW_DAU = 2000;
            const double GIA_50KW_TIET_THEO_1 = 2500;
            const double GIA_50KW_TIET_THEO_2 = 2800;
            const double GIA_TREN_200KW = 3500;

            double soKW = chiSoCuoi - chiSoDau;
            double tienDien = 0;

            if (soKW <= 100)
            {
                tienDien = soKW * GIA_100KW_DAU;
            }
            else if (soKW <= 150)
            {
                tienDien = 100 * GIA_100KW_DAU + (soKW - 100) * GIA_50KW_TIET_THEO_1;
            }
            else if (soKW <= 200)
            {
                tienDien = 100 * GIA_100KW_DAU + 50 * GIA_50KW_TIET_THEO_1 + (soKW - 150) * GIA_50KW_TIET_THEO_2;
            }
            else
            {
                tienDien = 100 * GIA_100KW_DAU + 50 * GIA_50KW_TIET_THEO_1 + 50 * GIA_50KW_TIET_THEO_2 + (soKW - 200) * GIA_TREN_200KW;
            }

            return tienDien;
        }
    }
}
