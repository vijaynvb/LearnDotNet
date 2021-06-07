using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class Calculator
    {
        void Main()
        {
            bool isExit = false;
            do{
                Console.WriteLine("My Calculator");
                Console.WriteLine("Please select your operation \n1-Add\n2-Subtraction\n3-Multiply\n4-Divison\n5-Exit");
                string option = Console.ReadLine();
                int[] a = new int[2];
                switch (option)
                {
                    case "1":
                        a = readData();
                        Console.WriteLine("Sum of {0} and {1} is :{2}", a[0], a[1], a[0] + a[1]);
                        break;
                    case "2":
                        a = readData();
                        Console.WriteLine("Subtract of {0} and {1} is :{2}", a[0], a[1], a[0] - a[1]);
                        break;
                    case "3":
                        a = readData();
                        Console.WriteLine("Multiplication of {0} and {1} is :{2}", a[0], a[1], a[0] * a[1]);
                        break;
                    case "4":
                        a = readData();
                        Console.WriteLine("Division of {0} and {1} is :{2}", a[0], a[1], a[0] / a[1]);
                        break;
                    case "5":
                        isExit = true;
                        Console.Write("Thank you");
                        break;
                    default:
                        Console.WriteLine("Select options from 1 to 5 only");
                        break;
                }
            } while (!isExit);
            Console.Read();
        }

        static int[] readData()
        {
            Console.WriteLine("Enter First value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return new int[]{ a, b};
        }
    }
}
