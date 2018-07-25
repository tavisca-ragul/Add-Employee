using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDetails
{
    class EmployeeOperations
    {
        private Employee[] employee;
        private int _numberOfEmployees;

        public delegate void displayEmployeeDepartment(String department);

        public EmployeeOperations()
        {
            employee = new Employee[10];
            _numberOfEmployees = 0;
        }

        public static void WriteToScreen(String department)
        {
            Console.WriteLine("Employee added under " + department + " department");
        }

        public void addEmployee(String employeeName, String qualification)
        {
            if(_numberOfEmployees < 10)
            {
                employee[_numberOfEmployees] = new Employee();
                employee[_numberOfEmployees].EmployeeName = "" + employeeName;
                employee[_numberOfEmployees].EmployeeID = _numberOfEmployees;
                employee[_numberOfEmployees].Qualification = "" + qualification;
                if(qualification.Equals("BE") || qualification.Equals("BCA") || qualification.Equals("BSC"))
                {
                    employee[_numberOfEmployees].Department = "" + "IT";
                }
                else if (qualification.Equals("BCom") || qualification.Equals("MCom") || qualification.Equals("CA"))
                {
                    employee[_numberOfEmployees].Department = "" + "Accounts";
                }
                displayEmployeeDepartment DED = new displayEmployeeDepartment(WriteToScreen);
                DED(employee[_numberOfEmployees].Department);
                _numberOfEmployees++;
            }
            else
            {
                Console.WriteLine("You have reached the maximum limit to add Employee");
            }
        }


        
    }
}