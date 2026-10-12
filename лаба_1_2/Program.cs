using System;

namespace варіант7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                TCircle c = new TCircle();
                c.Input();
                c.Output();
                Console.WriteLine("Площа круга: " + c.Area());
                Console.WriteLine("Довжина кола: " + c.Length());

                Console.Write("Кут сектора (у градусах) = ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Площа сектора: " + c.SectorArea(angle));

                TCircle copy = new TCircle(c);
                Console.WriteLine("c == copy: " + (c == copy));

                TCircle d = new TCircle(10);
                Console.WriteLine("c + d: " + (c + d));
                Console.WriteLine("c - d: " + (c - d));

                Console.Write("Число для множення k = ");
                double k = double.Parse(Console.ReadLine());
                Console.WriteLine("c * k: " + (c * k));
                Console.WriteLine("k * c: " + (k * c));

                TCone cone = new TCone();
                cone.Input();
                cone.Output();
                Console.WriteLine("Об'єм конуса: " + cone.Volume());
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
            }
        }
    }
}