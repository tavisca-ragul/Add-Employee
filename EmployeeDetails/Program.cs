using System;
using System.IO;
using System.Text;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            String employeeName, qualification;
            userInput:
            Console.Write("Enter 1 for Add Employee and 2 for EXIT: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input == 1)
            {
                try
                {
                    Console.Write("Enter Employee Name : ");
                    employeeName = Console.ReadLine();
                    Console.Write("Enter Employee Qualification : ");
                    qualification = Console.ReadLine();
                    if (qualification == "")
                        throw new QualificationIsEmpty("Qualification can't be Empty");
                    EmployeeOperations employeeOperations = new EmployeeOperations();
                    employeeOperations.addEmployee(employeeName, qualification);
                }
                catch(QualificationIsEmpty exception)
                {
                    Console.WriteLine(exception.Message);
                    using (FileStream fileStream = new FileStream("C:\\Users\\Krish\\source\\repos\\EmployeeDetails\\EmployeeDetails\\logfile.txt", FileMode.Append))
                    {
                        using (StreamWriter logFile = new StreamWriter(fileStream))
                        {
                            logFile.WriteLine(exception.Message);
                        }
                    }
                }
                finally
                {
                    employeeName = "";
                    qualification = "";
                }
                goto userInput;
            }
            else if(input == 2)
                Environment.Exit(0);
            else
            {
                Console.WriteLine("Wrong Choice, try again");
            }
            Console.ReadKey();
        }
    }
}
