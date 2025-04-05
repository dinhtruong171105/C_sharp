using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai011
{
    internal class DiemToaDo
    {
        public double x, y;
        public DiemToaDo(){}
        public void Nhap()
        {
            Console.Write("Nhập x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            y = double.Parse(Console.ReadLine());
        }
    }
}
