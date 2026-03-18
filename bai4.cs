using System;
using System.Collections.Generic;
using System.Text;

class bai4
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

        Console.WriteLine("Nhap day so:");
        string[] arr = Console.ReadLine().Split(' ');

        foreach (string s in arr)
        {
            ds.Add(int.Parse(s));
        }

        int dem = 0;

        foreach (int i in ds)
        {
            if (i % 2 == 0)
            {
                dem++;
            }
        }

        Console.WriteLine("So luong so chan la: " + dem);
    }
}
