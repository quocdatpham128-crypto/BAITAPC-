using System;
using System.Collections.Generic;
using System.Text;

class bai9
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
        List<int> kq = new List<int>();

        Console.WriteLine("Nhap day so:");
        string[] arr = Console.ReadLine().Split(' ');

        foreach (string s in arr)
        {
            ds.Add(int.Parse(s));
        }

        foreach (int i in ds)
        {
            if (!kq.Contains(i))
            {
                kq.Add(i);
            }
        }

        Console.WriteLine("Danh sach khong trung:");

        foreach (int i in kq)
        {
            Console.Write(i + " ");
        }
    }
}
