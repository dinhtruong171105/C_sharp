using System;
using System.Collections.Generic;

namespace Bai001
{
    internal class PhanSo : IComparable<PhanSo>
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo(int tu = 0, int mau = 1)
        {
            Tu = tu;
            Mau = mau == 0 ? 1 : mau;
            RutGon();
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());

            Console.Write("Nhập mẫu số: ");
            Mau = int.Parse(Console.ReadLine());

            if (Mau == 0)
            {
                Console.WriteLine("Mẫu số không thể bằng 0. Gán mẫu = 1.");
                Mau = 1;
            }

            RutGon();
        }

        public void Xuat()
        {
            if (Mau == 1)
                Console.WriteLine($"{Tu}");
            else
                Console.WriteLine($"{Tu}/{Mau}");
        }

        public static PhanSo Tong(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        }

        public static PhanSo Hieu(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        }

        public static PhanSo Tich(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
        }

        public static PhanSo Thuong(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
        }

        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(Tu), Math.Abs(Mau));
            Tu /= ucln;
            Mau /= ucln;

            // Đảm bảo mẫu số luôn dương
            if (Mau < 0)
            {
                Tu = -Tu;
                Mau = -Mau;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public int CompareTo(PhanSo other)
        {
            double val1 = (double)this.Tu / this.Mau;
            double val2 = (double)other.Tu / other.Mau;
            return val1.CompareTo(val2);
        }

        public override string ToString()
        {
            return Mau == 1 ? $"{Tu}" : $"{Tu}/{Mau}";
        }
    }
}
