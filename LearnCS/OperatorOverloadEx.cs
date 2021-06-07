using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class Fraction
    {
        public int x, y;
        public Fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Fraction operator + (Fraction a, Fraction b)
        {
            int x = a.x * b.y + b.x * a.y;
            int y = a.y * b.y;
            return new Fraction(x, y);
        }
        public static bool operator == (Fraction a, Fraction b)
        {
            return a.x == b.x ? a.y == b.y ? true : false : false;
        }
        public static bool operator != (Fraction a, Fraction b)
        {
            return a.x == b.x ? a.y == b.y ? false : true : true;
        }
    }
    class OperatorOverloadEx
    {
         void Main()
        {
            Fraction a = new Fraction(1, 2); // 1000
            Fraction b = new Fraction(1, 4); // 2000
            Fraction c = a + b;

            bool val = (a == b);

            Console.WriteLine("Fractions a and b are {0}", val?"eaqual":"not equal");
            Console.WriteLine("sum of two fractions is {0} {1}", c.x, c.y);
            Console.Read();
        }
    }
}
