using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai089
{
    internal class Bai089
    {
        static double S(double x, int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
                s += Math.Pow(-1, i) * Math.Pow(x, i) / (0.5 * i * (1 + i));
            return s;
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            double kq = S(x, n);
            Console.WriteLine("Kết quả: S(x,n) = " + kq);
            Console.Write("\n\n\nKết thúc!!!!!");
            Console.ReadLine();
        }
    }
}
