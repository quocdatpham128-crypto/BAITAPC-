using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
class bai15
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
        Dictionary<string, string> ds = new Dictionary<string, string>();
        Console.WriteLine("Nhap cac tu de tao tu dien");
        String[] ch = Console.ReadLine().Split();
        for ( int i= 0; i< ch.Length; i+= 2)
          ds.Add(ch[i], ch[i + 1]);
        Console.WriteLine("Nap tu de tra nghia");
        string t = Console.ReadLine();
        Console.WriteLine($"Nghia cua tu {t} la {ds[t]}");
           
        }
    }

