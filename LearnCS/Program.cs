using System;
using ta = TeamA;
using TeamB;


class Program
{
     void Main(string[] args)
    {

        int? ticketsonsale = 10;

        int availableTickets = ticketsonsale ?? 0;
   
        if(ticketsonsale==null)
            Console.WriteLine("Today we have not got any ticket for sale {0}", availableTickets);
        else
            Console.WriteLine("ticket for sale {0}", availableTickets);
        Console.Read();

        //a = null;

        //exConsoleReadnWrite();
        //exDatatypes();
        //exOperators();
        //exString();
        //singleArray();
        // multipleArray();
        //boxingUnboxing();
    }














    static void boxingUnboxing()
    {
        // boxing and unboxing

        int a = 10;
        float b = 1.13f;

        printdata(a);
        printdata(b);
        //printdata("vijay");
    }

    static void printdata(object obj)
    {
        Type intType = typeof(int);
        Type floatType = typeof(float);

        if(obj.GetType().Name == intType.Name)
        {
            int x = (int)obj + 10;
            Console.WriteLine("perform integer opweration {0}",x);
        }else if(obj.GetType().Name == floatType.Name)
        {
            float x = (float)obj + 10;
            Console.WriteLine("perform float opweration {0}", x);
        }
        else
        {
            Console.WriteLine(obj.ToString());
        } 
    }

    static void multipleArray()
    {
        // multi dimension array

        int[][] a = new int[3][];

        a[0] = new int[] { 1, 2, 3, 4 };
        a[1] = new int[] { 5, 6, 7 };
        a[2] = new int[] { 8 };
        a[3] = new int[2]; //{ 9, 0}

        a[3][0] = 9;
        a[3][1] = 0;

    }

    static void singleArray()
    {
        int[] a = { 1, 2, 3 };
        int[] b = new int[3]; // builtin data types have default values which will be assigned automatically, for int = 0, char ='\o'
        bool[] boo = new bool[2];
        int[] c = new int[] { 7, 8, 9, 1 };

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    static void exString()
    {
        // string is a reference type

        string str = "hello"; // hello is stored in 1000 memory bloc add and str is having 1000
        string str1 = str; // str1 = str = 1000
        str = "bye"; // str = bye = 2000
        // strings are immutable  

        String s = "hello";


        Console.WriteLine(str + " " + str1);
    }

    static void exOperators()
    {
        int a = 10, b = 10, c = 5;
        int i = 1;
        if (a == c & i++ == 2)
        {
            // & eveluates all conditions doesnt matter true are false
            // && evaluates the other conditions only when it is true

            Console.WriteLine("if block executed");
        }
        Console.WriteLine(i);
    }

    static void exDatatypes()
    {
        int a = 10, b;
        a = 3;
        float f1 = 1.3f;
        float f = a; // implicit conversion - CLR perform the conversion
        //b = (int) f1;  // explict conversion from higher order to lower order
        b = Convert.ToInt32(f1);

        bool isMajor = true;
        long l = 122342342;
        decimal d = 123123;

        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(decimal.MinValue);

        Console.WriteLine("b is {0} and f1 is {1}", b, f1);
        Console.Read();
    }

    static void exConsoleReadnWrite()
    {
        Console.WriteLine("Enter your First name");

        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your Last name");

        string lastName = Console.ReadLine();

        // string concat
        //Console.WriteLine("first name is " + firstName);
        // string substitution
        Console.WriteLine("welcome {0} is your full name is {0} {1}", firstName, lastName);

        Console.Read();
    }

}

// ctrl + d and K
/*
 * multiple lines
 * 
 */



