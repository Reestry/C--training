// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Task2
{
    public sealed class Driver : Employee
    {
        private string CarBrand { get; set; }
        private string CarModel { get; set; }

        public Driver()
        {
            Console.WriteLine("Вызван базовый конструктор Driver");
        }

        public Driver(string lastName, string firstName, string patronymic, DateTime birthdate,
            string organisation, int salary, string workLength, string carBrand, string carModel) : base(lastName,
            firstName, patronymic, birthdate, organisation, salary, workLength)
        {
            Console.WriteLine("Вызван конструктор Driver с параметрами");
            CarBrand = carBrand;
            CarModel = carModel;
        }

        public Driver(Driver other) : base(other)
        {
            CarBrand = other.CarBrand;
            CarModel = other.CarModel;
        }

        public override void Edit()
        {
            base.Edit();
            Console.WriteLine("Марка автомобиля:");
            CarBrand = Console.ReadLine();
            Console.WriteLine("Модель автомобиля:");
            CarModel = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Марка автомобиля:{CarBrand} Модель автомобиля:{CarModel}");
        }

        ~Driver()
        {
            Console.WriteLine("Вызван деструктор Driver");
        }
    }
}