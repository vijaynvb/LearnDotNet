using System;
using System.Reflection;

namespace LearnCS
{
    class ReflectionEx
    {
         void Main()
        {
            Console.WriteLine("Enter Class name to Print the details");
            string className = Console.ReadLine();

            Console.WriteLine("Print all the memebers of the given class: {0}", className);

            Type T = Type.GetType(className); //typeof(LearnCS.Printer); //


            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo m in methods)
                Console.WriteLine(m.Name);

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo p in properties)
                Console.WriteLine(p.Name);


            Console.Read();
        }
    }
}
