using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        // Hien thi list
        public static void HienThi(ref List<double> list, string mgs = "Danh sach vua nhap la: ")
        {

            // Hien thi loai danh sach duoc in ra
            Console.WriteLine(mgs);

            // foreach()
            list.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }


        //Sap xep list
        public static void SapXep(ref List<double> list)
        {

            // 
            list.Sort();
            HienThi(ref list, "Danh sach sau khi da sap xep: ");

        }

        // Xoa cac so am o dau
        public static void XoaSoAm(ref List<double> list)
        {
            List<double> newList = list.Where(x => x > 0).ToList();
            HienThi(ref newList, "Danh sach sau khi xoa so am la: ");
            list = newList;
        }

        // Nhap va chen mot so x theo thu tu
        public static void Chen(ref List<double> list)
        {
            Console.Write("Nhap vao mot so thuc: ");
            double x = double.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > x)
                {
                    list.Insert(i, x);
                    break;
                }
            }
            HienThi(ref list, $"Danh sach sau khi chen them {x} la: ");
        }

        // Them list vao file
        public static void InsertDataToText(ref List<double> list, string connectionData)
        {
            StreamWriter streamWriter = new StreamWriter(connectionData, false);
            streamWriter.WriteLine("Danh sach la: ");
            list.ForEach(x => streamWriter.Write($"{x} "));
            streamWriter.WriteLine();
            streamWriter.Close();
        }


        // Doc file
        public static void ReadDataFromText(ref List<double> list, string connectionData)
        {
            StreamReader streamReader = new StreamReader(connectionData);
            while (streamReader.Peek() != -1)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
        }

        // Main
        public static void Main(string[] args)
        {
            List<double> list = new List<double>();
            while (true)
            {
                Console.Write("nhap mot so thuc (nhap K de dung): ");
                string value = Console.ReadLine();
                if (value.ToUpper() == "K") break;
                list.Add(double.Parse(value));
            }
            HienThi(ref list);
            SapXep(ref list);
            XoaSoAm(ref list);
            Chen(ref list);
            InsertDataToText(ref list, "D:\\ListProblem\\Data.txt");
            ReadDataFromText(ref list, "D:\\ListProblem\\Data.txt");
        }
    }
}
