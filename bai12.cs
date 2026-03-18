using System;
using System.Collections.Generic;
using System.Text;
class student
    {
        public int Id;
        public string Name;

    }
class bai12
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
        List<student> ds = new List<student>();
        Console.WriteLine("Nhap danh sach sinh vien");
        String[] ch = Console.ReadLine().Split(' ');
        for (int i = 0; i < ch.Length; i += 2)
        {
            student sv = new student();
            sv.Id = int.Parse(ch[i]);
            sv.Name = ch[i + 1];
            ds.Add(sv);
        }
        Console.WriteLine("Nhap ten sinh vien can tim");
        string ten = Console.ReadLine();
        foreach (student sv in ds)
        {
            if (sv.Name == ten)
                Console.WriteLine($" Id {sv.Id} - Ten {sv.Name}");
        }
    }
}
