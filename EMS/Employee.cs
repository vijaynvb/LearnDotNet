using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Employee : Person
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }

        public Department department;

        public Employee() { }
        public Employee(int id, string firstName)
        {
            Id = id;
            this.FristName = firstName;
        }
    }
}
