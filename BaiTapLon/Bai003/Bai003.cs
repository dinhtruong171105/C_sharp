using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai003
{
    internal class Bai003
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo culture = new CultureInfo("vi-VN");

            while (true)
            {
                DateTime now = DateTime.Now;

                string thu = culture.DateTimeFormat.GetDayName(now.DayOfWeek);
                string ngay = now.ToString("d/M/yyyy");
                string gio = now.ToString("HH:mm:ss");

                Console.WriteLine($"Thời gian hiện tại: {thu}, ngày {ngay}, thời gian: {gio}");

                Thread.Sleep(1000); // Dừng 1 giây
            }
            //Console.ReadLine();
        }
    }
}
