using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Department
    { 
        int Id { get; set; }
        string Name { get; set; }

        public Department()
        {
        } 
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        
    }
}
