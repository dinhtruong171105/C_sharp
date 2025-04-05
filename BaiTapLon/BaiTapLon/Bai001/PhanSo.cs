using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai001
{
    internal class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo() { }

        public PhanSo(int Tu, int Mau)
        {
            Tu = Tu;
            Mau = Mau;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử: ");
            Tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu: ");
            Mau = int.Parse(Console.ReadLine());
            // Kiểm tra mẫu có phải là 0 không
            while (Mau == 0)
            {
                Console.Write("Mẫu không thể là 0, vui lòng nhập lại: ");
                Mau = int.Parse(Console.ReadLine());
            }
        }


    }
}
