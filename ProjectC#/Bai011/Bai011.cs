using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai011
{
    internal class Bai011
    {
        static double TinhDienTich(DiemToaDo A, DiemToaDo B, DiemToaDo C)
        {
            return (double)Math.Abs((B.x-A.x)*(C.y-A.y)-(C.x-A.x)*(B.y-A.y)) / 2.0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DiemToaDo A = new DiemToaDo();
            DiemToaDo B = new DiemToaDo();
            DiemToaDo C = new DiemToaDo();

            Console.WriteLine("Nhập tọa độ đỉnh A:");
            A.Nhap();
            Console.WriteLine("Nhập tọa độ đỉnh B:");
            B.Nhap();
            Console.WriteLine("Nhập tọa độ đỉnh C:");
            C.Nhap();
            double kq = TinhDienTich(A, B, C);
            Console.WriteLine("Diện tích tam giác ABC: S = " + kq);
            Console.Write("\n\n\nKết thúc!!!!!");

            Console.ReadLine();
        }
    }
}
