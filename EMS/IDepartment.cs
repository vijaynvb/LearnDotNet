using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    interface IDepartment
    {
        string getDepartmentDetails(int id);
        void createDepartment();
        void deleteDepartment(int id);
        void updateDepartment();
    }
}
