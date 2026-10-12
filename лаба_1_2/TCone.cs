using System;

namespace варіант7
{
    internal class TCone : TCircle
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