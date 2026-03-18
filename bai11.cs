using System;
using System.Collections.Generic;
using System.Text;
class student
{
    public int Id;
    public string Name;

}
 class bai11
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
        Console.WriteLine("Nhap so luong sinh vien: ");
        int sl = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thong tin sinh vien:");
        for (int i=0; i<sl; i++)
        {
            student sv = new student();
            Console.WriteLine($"Sinh vien thu {i + 1}:");
            sv.Id = int.Parse(Console.ReadLine());
            sv.Name = Console.ReadLine();
            ds.Add(sv);
        }
        foreach (student sv in ds)
        { 
            Console.WriteLine($"Id: {sv.Id}, Name: {sv.Name}");
        }
    }
}

