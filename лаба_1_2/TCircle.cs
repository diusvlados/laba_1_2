using System;

namespace варіант7
{
    internal class TCircle
    {
        protected double r;   // радіус

        public TCircle()
        {
            r = 1;
        }

        public TCircle(double r)
        {
            if (r < 0)
                throw new ArgumentException("Радіус не може бути від'ємним");
            this.r = r;
        }

        // Конструктор копіювання
        public TCircle(TCircle other)
        {
            r = other.r;
        }

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Радіус не може бути від'ємним");
                r = value;
            }
        }

        public void Input()
        {
            Console.Write("Радіус = ");
            R = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Коло, радіус = " + r;
        }

        // Площа круга
        public double Area()
        {
            return Math.PI * r * r;
        }

        // Площа сектора, кут у градусах (від 0 до 360)
        public double SectorArea(double angle)
        {
            if (angle < 0 || angle > 360)
                throw new ArgumentException("Кут має бути від 0 до 360 градусів");
            return Area() * angle / 360;
        }

        // Довжина кола
        public double Length()
        {
            return 2 * Math.PI * r;
        }

        // Порівняння
        public override bool Equals(object obj)
        {
            if (obj is TCircle other)
                return r == other.r;
            return false;
        }

        public static bool operator ==(TCircle c1, TCircle c2)
        {
            if (c1 is null || c2 is null)
                return c1 is null && c2 is null;
            return c1.r == c2.r;
        }

        public static bool operator !=(TCircle c1, TCircle c2)
        {
            return !(c1 == c2);
        }

        public static TCircle operator +(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.r + c2.r);
        }

        // При від'ємному результаті беремо модуль
        public static TCircle operator -(TCircle c1, TCircle c2)
        {
            return new TCircle(Math.Abs(c1.r - c2.r));
        }

        public static TCircle operator *(TCircle c, double k)
        {
            return new TCircle(Math.Abs(c.r * k));
        }

        public static TCircle operator *(double k, TCircle c)
        {
            return new TCircle(Math.Abs(c.r * k));
        }
    }
}