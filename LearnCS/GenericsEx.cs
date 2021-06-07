using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class GenericsEx
    {   
         void Main()
        {
            // is equality check 
            int a = 10, b = 20;
            string p = "10", q = "10";
            bool val = utils<int>.isEqual(a,b);
            bool val1 = utils<string>.isEqual(p, q);
        }

        public static bool isEqual<T>(T a, T b) // method being a generic type
        {
            return a.Equals(b);
        }
    }

    class utils<T>  // class with generic type
    {
        public static bool isEqual(T a, T b)
        {
            return a.Equals(b);
        }

        public static bool isValid(T a, T b)
        { 
            return a.Equals(b);
        }
    }
}
