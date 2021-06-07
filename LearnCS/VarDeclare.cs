using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class VarDeclare
    {
        public  void Main()
        {
            // how to pass parameter to methods
            // 1. pass by value
            // 2. pass by reference
            // 3. multiple return to your caller out
            // 4. params variable parametiers

            int x = 1; // 1000
            int b = 10;
            float y = 1.4f;
            compute(x); // pass by value 
            compute(y);

            //compute(ref x, ref b); // pass by reference // 1000
           
            //int p = 0, q = 0;

            //readData( out p, out q);


            ////Console.WriteLine("val of x {0} {1}", x, b);
            //Console.WriteLine("val of x {0} {1}", p,q);
            Console.Read();
        }

        public static void compute(int a) // int the value what you can is integer type
        {
            Console.WriteLine("Int value", ++a);
        }

        public static void compute(int a,int b) // int the value what you can is integer type
        {
            Console.WriteLine("Int value", ++a);
        }

        public static void compute(float a)
        {
            Console.WriteLine("Float value", ++a);
        }

        public static void compute(ref int a, ref int b) // int the value what you can is integer type
        {
            Console.WriteLine("val of a {0} {1}", ++a, b++);
        }

        static void readData( out int a, out int b)
        {
            Console.WriteLine("Enter First value: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
}
