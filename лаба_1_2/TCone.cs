using System;

namespace варіант7
{
    internal class TCone : TCircleF
    {
        private double h;   // висота конуса

        public TCone() : base()
        {
            h = 1;
        }

        public TCone(double r, double h) : base(r)
        {
            if (h < 0)
                throw new ArgumentException("Висота не може бути від'ємною");
            this.h = h;
        }

        public TCone(TCone other) : base(other)
        {
            h = other.h;
        }

        public double H
        {
            get
            {
                return h;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Висота не може бути від'ємною");
                h = value;
            }
        }

        // Об'єм конуса
        public double Volume()
        {
            return Area() * h / 3;
        }

        public static bool operator ==(TCone cone1, TCone cone2)
        {
            if (cone1 is null || cone2 is null)
                return cone1 is null && cone2 is null;
            return cone1.r == cone2.r && cone1.h == cone2.h;
        }

        public static bool operator !=(TCone cone1, TCone cone2)
        {
            return !(cone1 == cone2);
        }

        // Спершу вводимо радіус потім висоту
        new public void Input()
        {
            base.Input();
            Console.Write("Висота = ");
            H = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Конус, радіус = " + r + ", висота = " + h;
        }
    }
}