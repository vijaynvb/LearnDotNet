using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    class CoffeeBilling
    {
         void Main()
        {
            bool isExit = false;
            int finalBill = 0;
            do
            {
                Console.WriteLine("Coffee Billing system");
                Console.WriteLine("Please select your Coffee \n1-Small-10\n2-Medium-20\n3-large-30\n4-Exit");
                string option = Console.ReadLine();
                string status = null ;
                switch (option)
                {
                    case "1":
                        finalBill += 10;
                        Console.WriteLine("Do you want to by one more");
                        status = Console.ReadLine();
                        if (status == "n")
                            goto case "4";
                        break;
                    case "2":
                        finalBill += 20;
                        Console.WriteLine("Do you want to by one more");
                        status = Console.ReadLine();
                        if (status == "n")
                            goto case "4";
                        break;
                    case "3":
                        finalBill += 30;
                        Console.WriteLine("Do you want to by one more");
                        status = Console.ReadLine();
                        if (status == "n")
                            goto case "4";
                        break;
                    case "4":
                        isExit = true;
                        Console.WriteLine("Final bill is: {0}", finalBill);
                        break;
                    default:
                        break;
                } 
            } while (!isExit);

            Console.Read();
           }
    }
}
