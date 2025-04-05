using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai114
{
    internal class Bai114
    {
        static double S(int n)
        {
            double s  = -2;
            for (int i = 2; i <= n; i++)
                s = 5 * s + 2 * Math.Pow(3, i) - 6 * Math.Pow(7, i) + 12;
            return s;
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số hạng thứ n (n >= 2): ");
            int n = int.Parse(Console.ReadLine());
            double kq = S(n);
            Console.Write("Số hạng thứ " + n + " là: a" + n + " = " + kq);
            Console.Write("\n\n\nKết thúc!!!!!");
            Console.ReadLine();
        }
    }
}
