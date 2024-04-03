// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Task2
{
    public class Employee : Human
    {
        private string Organisation { get; set; }
        private int Salary { get; set; }
        private string WorkLength { get; set; }
        
        public Employee()
        {
            Console.WriteLine("Вызван базовый конструктор Employee");
        }

        public Employee(string lastName, string firstName, string patronymic, DateTime birthdate,
            string organisation, int salary, string workLength) : base(lastName, firstName, patronymic, birthdate)
        {
            Console.WriteLine("Вызван конструктор Student с параметрами");
            Organisation = organisation;
            Salary = salary;
            WorkLength = workLength;
        }

        protected Employee(Employee other) : base(other)
        {
            Console.WriteLine("Вызван копирующий конструктор Student");
            Organisation = other.Organisation;
            Salary = other.Salary;
            WorkLength = other.WorkLength;
        }

        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Организация:");
            Organisation = Console.ReadLine();
            Console.WriteLine("Зарплата:");
            Salary = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Стаж:");
            WorkLength = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Организация: {Organisation} Зарплата: {Salary} Стаж: {WorkLength}");
        }

        ~Employee()
        {
            Console.WriteLine("Вызван деструктор Employee");
        }
    }
}