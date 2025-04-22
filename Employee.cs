using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_lab1_2_git_2
{
    internal class Employee
    {
            // Backing fields
            private string _name;
            private decimal _salary;

            // Properties with backing fields
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public decimal Salary
            {
                get { return _salary; }

                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Salary cannot be negative. Setting salary to 0.");
                        _salary = 0;
                    }
                    else
                    {
                        _salary = value;
                    }
                }
            }

            // Constructor
            public Employee(string name, decimal salary)
            {
                Name = name;
                Salary = salary;
            }

            // Method to increase salary by a percentage
            public void IncreaseSalary(decimal percentage)
            {
                if (percentage < 0)
                {
                    Console.WriteLine("Percentage cannot be negative.");
                    return;
                }
                Salary += Salary * (percentage / 100);
            }

            // Method to display employee details
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
            }
    }

}


