using System;
using System.Collections.Generic;
using System.Text;
class bai10
    {
        static void GT()
        {
            Console.WriteLine("Pham Quoc Dat");
            Console.WriteLine("2415053122205");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            GT();
            Console.WriteLine("nhap danh sach so nguyen");
            String[] chuoi = Console.ReadLine().Split(' ');
            int min=int.MaxValue,tg;
            foreach (string s in chuoi)
            {
                tg = int.Parse(s);
                if (min > tg) min = tg;
            }
        Console.WriteLine($"gia tri nho nhat trong danh sach la: {min}");
        }
    }

