using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class bai1
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
        string[] ch = Console.ReadLine().Split(' ');
        foreach (string s in ch)
        {
            ds.Add(int.Parse(s));
        }
        Console.WriteLine("Nhap 5 so can them:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so thu " + (i + 1) + ": ");
            int so = int.Parse(Console.ReadLine());
            ds.Add(so);
        }
        Console.WriteLine("Danh sach sau khi them:");

        foreach (int i in ds)
        {
            Console.Write(i + " ");
        }
    }
}