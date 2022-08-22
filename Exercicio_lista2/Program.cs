using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How Many Employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #{0}:", i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("");

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Entre the employee 'Id' will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);

            }
            else
            {
                Console.WriteLine("Id: " + searchId + " Does not exists!");
            }
            Console.Write("\nUpdated list of employees:\n");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
