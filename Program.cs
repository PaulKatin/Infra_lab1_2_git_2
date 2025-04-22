using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_lab1_2_git_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee emp = new Employee("Alice Johnson", 45000);

            // Display initial details
            Console.WriteLine("Initial Employee Details:");
            emp.DisplayInfo();

            // Increase salary by 15%
            Console.WriteLine("\nIncreasing salary by 15%...");
            emp.IncreaseSalary(15);

            // Display updated details
            Console.WriteLine("Updated Employee Details:");
            emp.DisplayInfo();

        }

    }
}
