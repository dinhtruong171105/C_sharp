using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai059
{
    internal class Bai059
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            while (n >= 1)
            {
                n /= 10;
                s++;
            }
            Console.Write("Số lượng chữ số của số nguyên n: " + s);
            Console.Write("\n\n\nKết thúc!!!!!");
            Console.ReadLine();
        }
    }
}
