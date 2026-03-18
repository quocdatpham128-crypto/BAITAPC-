using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
class bai16
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
        Dictionary<char, int> dem = new Dictionary<char, int>();
        Console.WriteLine("Nhap tu: ");
        string s = Console.ReadLine();
        foreach (char c in s)
        {
            if (dem.ContainsKey(c))
                dem[c]++;
            else
                dem[c] = 1;
        }
        foreach (var item in dem)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}

