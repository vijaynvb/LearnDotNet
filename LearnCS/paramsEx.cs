using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class paramsEx
    {
         void Main()
        {
            int[] num = { 1, 2, 4 };
            int a, b, c;
            a=sumOfNNumbers(1);
            b=sumOfNNumbers(num);
            c=sumOfNNumbers(1, 2, 3, 4, 5);

            WriteLine("Values of a {0} b {1} c {2}", a, b, c);
            Console.Read();
        }

        static int sumOfNNumbers(params int[] Number)
        {
            int sum = 0;
            foreach(int i in Number)
                sum += i;
            return sum;
        }

        static void WriteLine(string str, params object[] args)
        {
            for(int i=0; i< args.Length; i++)
            {
                string temp = String.Concat("{",i,"}");
                str = str.Replace(temp, args[i].ToString());
            }  
            Console.WriteLine(str);
        }
    }
}
