using System;

namespace cs_lab;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.LastName = "Janusz";
        Console.WriteLine(employee.LastName);

        DateTime value = new DateTime(2024, 03, 01);
        employee.EmploymentDate = value;
        Console.WriteLine(employee.EmploymentDate);

        employee.Salary = -500;
        Console.WriteLine(employee.Salary);


    }
}
