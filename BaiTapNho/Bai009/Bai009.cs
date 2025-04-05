using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai009
{
    internal class Bai009
    {
        static double S(int n, float r)
        {
            return 0.5 * n * Math.Pow(r, 2) * Math.Sin(2 * Math.PI / n);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập bán kính r: ");
            float r = float.Parse(Console.ReadLine());
            double kq = S(n, r);
            Console.WriteLine("Kết quả: S = " + kq);
            Console.Write("\n\n\nKết thúc!!!!!");
            Console.ReadLine();
        }
    }
}
