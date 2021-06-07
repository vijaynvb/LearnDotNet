using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{

    enum empMenu
    {
        create_Employee,
        list_Employee,
        update_Employee,
        delete_Employee,
        search_Employee,
        end = 9
    }
    enum deptMenu
    {
        create_Department,
        list_Department,
        update_Department,
        delete_Department,
        search_Department,
        end = 9
    }

    class EnumsEx
    {
        // Enum = Enuumuration it is a datatype which holds data as key value pairs:

        static void menuPrint(Enum e)
        {
            int[] intVaule = (int[])Enum.GetValues(e.GetType());
            string[] stringVlue = (string[])Enum.GetNames(e.GetType());
            for (int i = 0; i < intVaule.Length; i++)
                Console.WriteLine($"{intVaule[i]} - {stringVlue[i]}");
        }


        static void Main()
        {
            bool isEnd = false;
            do
            {
                Console.WriteLine("Select your option");
                //Console.WriteLine("1-Create Employee\n2-Update Employee\n3-Delete Employee\n4-List Employees\n5-Search by ID\n6-End");
                menuPrint(new empMenu());

                menuPrint(new deptMenu());

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                switch ((empMenu)option)
                {
                    case empMenu.create_Employee:
                        Console.WriteLine("case 1");
                        break;
                    case empMenu.update_Employee:
                        Console.WriteLine("case 1");
                        break;
                    case empMenu.delete_Employee:
                        Console.WriteLine("case 1");
                        break;
                    case empMenu.list_Employee:
                        Console.WriteLine("case 1");
                        break;
                    case empMenu.search_Employee:
                        Console.WriteLine("case 1");
                        break;
                    case empMenu.end:
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Please enter only numbers from 1 to 6");
                        break;
                }
            } while (!isEnd);
            Console.Read();
        }
    }
}
