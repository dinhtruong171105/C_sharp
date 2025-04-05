using System;
using System.Collections.Generic;
using System.Text;

namespace Bai001
{
    internal class Bai001
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<PhanSo> danhSach = new List<PhanSo>();

            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSach.Add(ps);
            }

            Console.WriteLine("\nDanh sách phân số đã nhập:");
            foreach (var ps in danhSach)
                ps.Xuat();

            // Sắp xếp tăng dần
            danhSach.Sort();
            Console.WriteLine("\nDanh sách phân số sau khi sắp xếp tăng dần:");
            foreach (var ps in danhSach)
                ps.Xuat();

            // Sắp xếp giảm dần
            danhSach.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("\nDanh sách phân số sau khi sắp xếp giảm dần:");
            foreach (var ps in danhSach)
                ps.Xuat();

            if (danhSach.Count >= 2)
            {
                var a = danhSach[0];
                var b = danhSach[1];

                Console.WriteLine($"\nTổng {a} + {b} = {PhanSo.Tong(a, b)}");
                Console.WriteLine($"Hiệu {a} - {b} = {PhanSo.Hieu(a, b)}");
                Console.WriteLine($"Tích {a} * {b} = {PhanSo.Tich(a, b)}");
                Console.WriteLine($"Thương {a} / {b} = {PhanSo.Thuong(a, b)}");
            }

            Console.ReadLine();
        }
    }
}
