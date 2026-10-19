using System;
using System.Collections.Generic;

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

                // Конструктор копіювання: копія незалежна від оригіналу
                TCircle copy = new TCircle(c);
                copy.R = c.R + 1;
                Console.WriteLine("c: " + c);
                Console.WriteLine("copy (змінили): " + copy);

                // Порівняння й оператори з іншим колом
                TCircle other = new TCircle();
                Console.WriteLine("Введіть інше коло:");
                other.Input();
                Console.WriteLine("c == other: " + (c == other));
                Console.WriteLine("c != other: " + (c != other));
                Console.WriteLine("c + other: " + (c + other));
                Console.WriteLine("c - other: " + (c - other));

                Console.Write("Число для множення k = ");
                double k = double.Parse(Console.ReadLine());
                Console.WriteLine("c * k: " + (c * k));
                Console.WriteLine("k * c: " + (k * c));

                // Конус
                TCone cone = new TCone();
                cone.Input();
                cone.Output();
                Console.WriteLine("Об'єм конуса: " + cone.Volume());

                // Порівняння з іншим конусом
                TCone otherCone = new TCone();
                Console.WriteLine("Введіть інший конус:");
                otherCone.Input();
                Console.WriteLine("cone == otherCone: " + (cone == otherCone));
                Console.WriteLine("cone != otherCone: " + (cone != otherCone));

                // Об'єми обох конусів 
                Console.WriteLine("Об'єм першого конуса: " + cone.Volume());
                Console.WriteLine("Об'єм іншого конуса: " + otherCone.Volume());

                // HashSet<TCircle>
                HashSet<TCircle> set1 = new HashSet<TCircle>();
                set1.Add(new TCircle(5));
                TCircle search1 = new TCircle(5);
                Console.WriteLine("TCircle знайдено: " + set1.Contains(search1));

                //  HashSet<TCircleF>
                HashSet<TCircleF> set2 = new HashSet<TCircleF>();
                set2.Add(new TCircleF(5));
                TCircleF search2 = new TCircleF(5);
                Console.WriteLine("TCircleF знайдено: " + set2.Contains(search2));

                //  HashSet<TCone> однаковий радіус, різна висота
                HashSet<TCone> set3 = new HashSet<TCone>();
                for (int i = 1; i <= 5; i++)
                {
                    set3.Add(new TCone(2, i));
                }
                Console.WriteLine("Кількість у HashSet<TCone>: " + set3.Count);

                //  HashSet<TConeF> однаковий радіус різна висота
                HashSet<TConeF> set4 = new HashSet<TConeF>();
                for (int i = 1; i <= 5; i++)
                {
                    set4.Add(new TConeF(2, i));
                }
                Console.WriteLine("Кількість у HashSet<TConeF>: " + set4.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
            }
        }
    }
}