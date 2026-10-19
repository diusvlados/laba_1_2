using System;

namespace варіант7
{
    internal class TConeF : TCone
    {
        public TConeF() : base()
        {
        }

        public TConeF(double r, double h) : base(r, h)
        {
        }

        public TConeF(TCone other) : base(other)
        {
        }

        // Конуси рівні, якщо рівні і радіус, і висота
        public override bool Equals(object obj)
        {
            if (obj is TCone other)
                return r == other.R && H == other.H;
            return false;
        }

        public override int GetHashCode()
        {
            return 17 * r.GetHashCode() + 31 * H.GetHashCode();
        }
    }
}