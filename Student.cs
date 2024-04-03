// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Task2
{
    public class Student : Human
    {
        private string Faculty { get; set; }
        private int Course { get; set; }
        private string Group { get; set; }
        
        public Student()
        {
            Console.WriteLine("Вызван базовый конструктор Student");
        }

        public Student(string lastName, string firstName, string patronymic, DateTime birthdate,
            string faculty, int course, string group) : base(lastName, firstName, patronymic, birthdate)
        {
            Console.WriteLine("Вызван конструктор Student с параметрами");
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        public Student(Student other) : base(other)
        {
            Console.WriteLine("Вызван копирующий конструктор Student");
            Faculty = other.Faculty;
            Course = other.Course;
            Group = other.Group;
        }

        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Факультет");
            Faculty = Console.ReadLine();
            Console.WriteLine("Номер курса:");
            Course = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Группа:");
            Group = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Факультет: {Faculty} Номер курса: {Course} Группа {Group}");
        }

        ~Student()
        {
            Console.WriteLine("Вызван деструктор Student");
        }
    }
}