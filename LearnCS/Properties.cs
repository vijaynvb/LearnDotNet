using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{

    class Employee
    {
        private int age; // 18 
        private string name; // name cannot be null

        public Employee(int age, string name, int empid)
        {
            if (age <= 18)
                throw new Exception("age is not sufficent to be an employee");
            this.age = age;
            this.name = name;
            //this.empID = empid;
        }

        // properties
        public int Age
        {
            set
            {
                if (value <= 18)
                    throw new Exception("you cant do this");
                this.age = value;
            }
            get
            {
                return this.age;

            }
        }

        public int EmpId { get; set; }


    }


    class Properties
    {
         void Main()
        {
            Employee emp1 = new Employee(20, "vijay", 20);
            emp1.Age = 1;

            Console.WriteLine(emp1.Age);
            Console.Read();
        }
    }
}
