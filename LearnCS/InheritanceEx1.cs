using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class A { public virtual void print() { Console.WriteLine("Default behavious by Class A"); } }
    class B : A { public override void print() { Console.WriteLine("Specific Behaviour for class B"); } }

    class C : B { public override void print() { Console.WriteLine("Specific Behaviour for class C"); } }
    class InheritanceEx1
    {
         void Main()
        {
            A a = new C();

            a.print();

            // isnasKeywords();
            Console.Read();
        }


         void isnasKeywords()
        {
            A a = new C();
            // bool val = a is B; // verifying what type of object the variable holds

            // B b = (B) a;
            B b = a as B; // a variable has an object of type C, here we are typecasting the C object to be stored in b variable
                          // B b = new C();
            C c = a as C;
            b.print();
            c.print();
            //Console.WriteLine();
        }
    }
}
