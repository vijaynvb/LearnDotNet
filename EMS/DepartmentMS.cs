using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    // stubs
    class DepartmentMS : IDepartment
    {
        static List<Department> deptList = new List<Department>();

        static DepartmentMS()
        {
            deptList.Add(new Department(1, "IT"));
            deptList.Add(new Department(2, "Accounts"));
        }

        public void createDepartment()
        {
            throw new NotImplementedException();
        }

        public void deleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public string getDepartmentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void updateDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
