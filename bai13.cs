using System;
using System.Collections.Generic;
using System.Text;
class student
{
    public int Id;
    public string Name;

}
class bai13
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
        Console.WriteLine($"so luong sinh vien {ch.Length/2}");
    }
}
