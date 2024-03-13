using System;

public class Employee
{
    private string _lastName;
    private DateTime _employmentDate;
    public decimal _salary;

    // Dla Nazwisko zaimplementuj obcinanie spacji przed i po
    public string LastName { get => _lastName; set => _lastName = value; }
    // Dla DataZatrudnienia zaimplementuj nie pozniej niz dzisiaj
    public DateTime EmploymentDate
    {
        get => _employmentDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException();
            _employmentDate = value;
        }
    }
    // Dla Wynagrodzenie zaimplementuj przy próbie podstawienia wartości ujemnej, przypisz 0. 
    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                _salary = 0;
            else
                _salary = value;
        }
    }
}