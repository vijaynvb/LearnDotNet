using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class A1 { 
        public A1():this("Hello"){ Console.WriteLine("Constructor of Class A"); }
        public A1(string msg) { Console.WriteLine("Constructor of Class A with msg {0}", msg); }

        public void print() { }

    }
    class B1 : A1 { public B1():base() { Console.WriteLine(" Constructor of class B"); } }

    class C1 : B1 { public C1() { Console.WriteLine("Constructor of class C"); } }
    class InhertanceConstructorEx
    {
         void Main()
        {
            A1 a = new C1();
            Console.Read();
        }
    }
}

