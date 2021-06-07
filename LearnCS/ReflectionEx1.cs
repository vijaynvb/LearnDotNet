using System;
using System.Reflection;

namespace LearnCS
{
    public class Employees {
        public int Id { get; set; }
        public string Name { 
            get {
                return "vijay"; 
            } 
            set { } }
        public string getName(){
            return this.Name;
        }
    }
    class ReflectionEx1
    {
        // how can you create objects - new, reflection, clone
        // Employees e = new Employees();
         void Main()
        {
            Assembly executeAssembly = Assembly.GetExecutingAssembly();

            Type empType = executeAssembly.GetType("LearnCS.Employees");

            MethodInfo getNameMethod = empType.GetMethod("getName"); // pointer for your method

            object objEmpInstamce = Activator.CreateInstance(empType); // object of the class to invoke instance methods

            string[] parameters = new string[0];

            string value = (string) getNameMethod.Invoke(objEmpInstamce, parameters);

            Console.WriteLine(value);
            Console.Read();
        }
    }

    public class Customers
    {
        public int Id { get; set; }
        public string Name
        {
            get
            {
                return "vijay";
            }
            set { }
        }
        public string getName()
        {
            return this.Name;
        }
    }
}
