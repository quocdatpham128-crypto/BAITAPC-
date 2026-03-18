using System;
using System.Collections.Generic;
using System.Text;

class bai5
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

        Console.WriteLine("Nhap danh sach ten:");
        string[] arr = Console.ReadLine().Split(' ');

        foreach (string s in arr)
        {
            ds.Add(s);
        }

        Console.WriteLine("Nhap ten can xoa:");
        string ten = Console.ReadLine();

        ds.Remove(ten);

        Console.WriteLine("Danh sach sau khi xoa:");

        foreach (string s in ds)
        {
            Console.Write(s + " ");
        }
    }
}
