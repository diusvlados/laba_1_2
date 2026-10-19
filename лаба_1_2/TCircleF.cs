using System;

namespace варіант7
{
    internal class TCircleF : TCircle
    {
        public TCircleF() : base()
        {
        }

        public TCircleF(double r) : base(r)
        {
        }

        public TCircleF(TCircle other) : base(other)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj is TCircle other)
                return r == other.R;
            return false;
        }

        public override int GetHashCode()
        {
            return r.GetHashCode();
        }
    }
}