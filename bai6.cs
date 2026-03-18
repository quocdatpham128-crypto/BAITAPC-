using System;
using System.Collections.Generic;
using System.Text;

class bai6
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
        List<string> ds = new List<string>();

        Console.WriteLine("Nhap danh sach chuoi:");
        string[] arr = Console.ReadLine().Split(' ');

        foreach (string s in arr)
        {
            ds.Add(s);
        }

        Console.WriteLine("Nhap chuoi can kiem tra:");
        string kt = Console.ReadLine();

        if (ds.Contains(kt))
        {
            Console.WriteLine("Chuoi ton tai trong danh sach");
        }
        else
        {
            Console.WriteLine("Chuoi khong ton tai");
        }
    }
}