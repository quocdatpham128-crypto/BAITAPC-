using System;
using System.Collections.Generic;
using System.Text;
class bai2
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
        List<int> ds = new List<int>();

        Console.WriteLine("Nhap day so :");

        string[] arr = Console.ReadLine().Split(' ');

        foreach (string s in arr)
        {
            ds.Add(int.Parse(s));
        }

        int tong = 0;

        foreach (int i in ds)
        {
            tong += i;
        }

        Console.WriteLine("Tong cac phan tu la: " + tong);
    }
}
