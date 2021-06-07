using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    
    class Person // Title case = first letter will be capital
    {
        // Member Variable - state
        public string firstName;
        public string lastName;
        public int age;

        // constructors to intialize the data 
        //public Person() // default constructor
        //{
        //    this.firstName = "NA"; // camel case = firstletter of first word is small and newwords first letter will be capital
        //    this.lastName = "NA";
        //    this.age = 0;
        //}

        public Person() : this("NA", "NA", 0)
        {
        }

        public Person(string firstName, string lastName, int age) // Parameterrized constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        // Member Methods - behavior - operations

        // give a full name as a operation

        public string fullName()
        {
            return this.firstName + " " + this.lastName;
        }

        ~Person()
        {
            // connectivity to database you can release it here
            // file pointer 
        }
    }
    
    class ClassEx
    {
         void Main()
        {
            Person p = new Person();
            Person p1 = new Person("vijay1","r",10);
           
            Console.WriteLine();
            Console.WriteLine(p1.fullName());
            Console.Read();
        }
    }
}
