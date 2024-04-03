// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Task2
{
    public abstract class Human
    {
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private string Patronomyc { get; set; }
        private DateTime Birthdate { get; set; }

        protected Human()
        {
            Console.WriteLine("Вызван стартовый конструктор Human.");
        }

        protected Human(string lastName, string firstName, string patronymic, DateTime birthdate)
        {
            Console.WriteLine("Вызван конструктор Human с параметрами.");
            LastName = lastName;
            FirstName = firstName;
            Patronomyc = patronymic;
            Birthdate = birthdate;
        }

        protected Human(Human other)
        {
            Console.WriteLine("Вызван копирующий конструктор Human.");
            LastName = other.LastName;
            FirstName = other.FirstName;
            Patronomyc = other.Patronomyc;
            Birthdate = other.Birthdate;
        }

        public virtual void Edit()
        {
            Console.WriteLine("Напиши фамилию");
            LastName = Console.ReadLine();
            Console.WriteLine("Напиши имя");
            FirstName = Console.ReadLine();
            Console.WriteLine("Напиши отчество");
            Patronomyc = Console.ReadLine();
            Console.WriteLine("Напиши дату рождения (дд.мм.гг)");
            Birthdate = DateTime.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine(
                $"Фамилия: {LastName} Имя: {FirstName} Отчество: {Patronomyc} Дата рождения: {Birthdate} " +
                $"Количество полных лет: {GetAge()}");
        }

        private int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Birthdate.Year;

            if (today < Birthdate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        ~Human()
        {
            Console.WriteLine("Вызван деструктор");
        }
    }
}