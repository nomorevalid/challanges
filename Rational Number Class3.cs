using System;
namespace Program
{
    public struct Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)throw new ArgumentException();
            else if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            var factor = CommonFactor(numerator, denominator);
            Numerator = numerator / factor;
            Denominator = denominator / factor;
        }
        public override string ToString() => Denominator == 1 ? Numerator.ToString() : Numerator + "/" + Denominator;
        private static int CommonFactor(int x, int y)
        {
            for (int i = Math.Max(x, y); i > 1; i--)
                if (x % i == 0 && y % i == 0)
                    return i;
            return 1;
        }
        public int Sign
        {
            get { return Numerator > 0 ? 1 : Numerator < 0 ? -1 : 0; }
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            int r1d = r1.Denominator;
            int r2d = r2.Denominator;
            if (r1d == r2d)return new Rational(r1.Numerator + r2.Numerator, r1d);
            return new Rational(r1.Numerator * r2d + r2.Numerator * r1d, r1d * r2d);
        }
        public static Rational operator +(Rational r2) => r2;
        public static Rational operator /(Rational r1, Rational r2)
        {
            if (r1.Numerator == 0)throw new DivideByZeroException();
            return new Rational(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }
        public static Rational operator -(Rational r2) => new Rational(-r2.Numerator, r2.Denominator);
        public static Rational operator *(Rational r1, Rational r2) => new Rational(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
    }
}
namespace Classes
{
    public struct Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public int Sign
        {
            get { return Numerator > 0 ? 1 : Numerator < 0 ? -1 : 0; }
        }
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException();
            else if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            Numerator = numerator;
            Denominator = denominator;
            CommonFactor(numerator, denominator);
        }
        public override string ToString() => Denominator == 1 ? Numerator.ToString() : Numerator + "/" + Denominator;
        private void CommonFactor(int numerator, int denominator)
        {
            int min = Math.Min(Math.Abs(numerator), Math.Abs(denominator));
            int gcf = 1;
            for (int i = 2; i <= min; i++)
                if ((numerator % i == 0) && (denominator % i == 0))
                    gcf = i;
            if (gcf > 1)
            {
                Numerator = numerator / gcf;
                Denominator = denominator / gcf;
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }
            if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
            if (numerator == 0)
                Numerator = 1;
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            int r1d = r1.Denominator;
            int r2d = r2.Denominator;
            if (r1d == r2d) return new Rational(r1.Numerator + r2.Numerator, r1d);
            return new Rational(r1.Numerator * r2d + r2.Numerator * r1d, r1d * r2d);
        }
        public static Rational operator +(Rational r2) => r2;
        public static Rational operator -(Rational r1, Rational r2)
        {
            int r1d = r1.Denominator;
            int r2d = r2.Denominator;
            if (r1d == r2d)return new Rational(r1.Numerator - r2.Numerator, r1d);
            return new Rational(r1.Numerator * r2d - r2.Numerator * r1d, r1d * r2d);
        }
        public static Rational operator -(Rational r2) => new Rational(-r2.Numerator, r2.Denominator);
        public static Rational operator *(Rational r1, Rational r2) => new Rational(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        public static Rational operator /(Rational r1, Rational r2)
        {
            if (r2.Numerator == 0) throw new DivideByZeroException();
            return new Rational(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }
        public static bool operator ==(Rational r1, Rational r2) => r1.Equals(r2);
        public static bool operator !=(Rational r1, Rational r2) => !r1.Equals(r2);
        public static bool operator >(Rational r1, Rational r2) => r1.Numerator > r2.Numerator;
        public static bool operator <(Rational r1, Rational r2) => r1.Numerator < r2.Numerator;
        public static bool operator >=(Rational r1, Rational r2) => r1.Numerator >= r2.Numerator;
        public static bool operator <=(Rational r1, Rational r2) => r1.Numerator <= r2.Numerator;
        public override bool Equals(object o)=> base.Equals(o);
        public override int GetHashCode()=> base.GetHashCode();
        public static implicit operator decimal(Rational r1) => Decimal.Divide(r1.Numerator,r1.Denominator);
        public static Rational DecimalToRational(decimal d)
	      {
	        int _d=1;
	        while(d%1 > 0)
	        {
		        d*=10;
		       _d*=10;
	    		}
	   		 return new Rational(Convert.ToInt32(d),_d);
		  	}
      public static explicit operator Rational(decimal d)=> DecimalToRational(d);
    }
}