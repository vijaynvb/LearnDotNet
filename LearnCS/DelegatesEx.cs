using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    delegate int Notifier(string message);

    class Dummy
    {
        public  int SayHello(string message)
        {
            Console.WriteLine("Hello " + message);
            return 1;
        }
        public  int SayBye(string message)
        {
            Console.WriteLine("Bye" + message);
            return 2;
        }
    }

    class DelegatesEx
    {
        
         void Main()
        {
            Dummy d = new Dummy();
            Notifier greet = null;
            Console.WriteLine("Which Method to Invoke \n1-sayhello\n2-saybye\n3-Invoke both");
            string input = Console.ReadLine();

            if(input=="1")
                greet = new Notifier(d.SayHello);
            else if( input =="2")
                greet = new Notifier(d.SayBye);
            else if (input == "3")
            {
                greet = new Notifier(d.SayHello);
                greet += new Notifier(d.SayBye);

                greet -= new Notifier(d.SayBye);
            }

            int a =  greet("Vijay");
            Console.WriteLine(a);
            //SayHello("Hello");
            Console.Read();

        }
    }
}
