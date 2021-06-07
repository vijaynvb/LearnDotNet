using System;
using System.Collections.Generic;

namespace EMS
{
  
    class EMS
    {
        // Employee[] empList = new Employee[100];

        static List<Employee> empList = new List<Employee>();

        static EMS() // it invokes once when the class is loaded and populates the fields 
        {
            empList.Add(new Employee(1,"vijay"));
            empList.Add(new Employee(2, "Jai"));
            empList.Add(new Employee(3, "abc"));
        }

        
        static void Main()
        {
            bool isExit = false;
            IDepartment DMS = new  DepartmentMS();
            do
            {
                try{
                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Select Entity To Manage");
                    Console.WriteLine("1-Employee\n2-Department\n3-Exit");
                    int entityOption = Convert.ToInt32(Console.ReadLine());
                    bool isEnd = false;
                    switch (entityOption){
                        case 1: // manage employees
                                do{
                                    Console.WriteLine("Select your option");
                                    Console.WriteLine("1-Create Employee\n2-Update Employee\n3-Delete Employee\n4-List Employees\n5-Search by ID\n6-End");
                                    int option = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                    switch (option)
                                    {
                                        case 1:
                                            createEmp();
                                            break;
                                        case 2:
                                            updateEmp();
                                            break;
                                        case 3:
                                            deleteEmp();
                                            break;
                                        case 4:
                                            getEmps();
                                            break;
                                        case 5:
                                            getEmp();
                                            break;
                                        case 6:
                                            isEnd = true;
                                            break;
                                        default:
                                            Console.WriteLine("Please enter only numbers from 1 to 6");
                                            break;
                                    }
                                } while (!isEnd);
                            break;
                        case 2: // manage deaprtment
                            
                            do
                            {
                                Console.WriteLine("Select your option");
                                Console.WriteLine("1-Create Department\n2-Update Department\n3-Delete Department\n4-List Depatments\n5-End");
                                int option = Convert.ToInt32(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        DMS.createDepartment();
                                        break;
                                    case 2:
                                       
                                        break;
                                    case 3:
                                        // check if any employee is using the department if yes then dont delete it
                                        break;
                                    case 4:
                                        
                                        break;
                                    case 5:
                                        isEnd = true;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter only numbers from 1 to 6");
                                        break;
                                }
                            } while (!isEnd);
                            break;
                        case 3:
                            isExit = true;
                            break;
                        default:

                            break;
                    }
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Application encounter error");
                }
            } while (!isExit);

            
        }

        static void createEmp()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter first name:");
            emp.FristName = Console.ReadLine();
            Console.WriteLine("Id:");
            emp.Id = Convert.ToInt32( Console.ReadLine());
            empList.Add(emp);
        }

        static void updateEmp()
        {
            Console.WriteLine("Update Employee");
        }

        static void deleteEmp()
        {
            getEmps();
            Console.WriteLine("select employee id:");
            int id = Convert.ToInt32( Console.ReadLine());
            foreach (Employee emp in empList)
            {
                if (emp.Id == id)
                {
                    empList.Remove(emp);
                    Console.WriteLine("Employee deleted successfully");
                    return;
                } 
            }
            Console.WriteLine("Employee id doesnt exist");
        }

        static void getEmp()
        {
            Console.WriteLine("get Employee");
        }

        static void getEmps()
        {
            //if(empList.Count == 0)
            foreach (Employee emp in empList)
                Console.WriteLine("Employee Id: {0} Name: {1}", emp.Id, emp.FristName);
        }
    }
}
