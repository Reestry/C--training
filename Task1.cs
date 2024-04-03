// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Exercise_1
{
    public static class Task1
    {
        public static void Complete()
        {
            Console.WriteLine("Введите три целых числа:");
            var numbers = new int[3];
            for (var i = 0; i < 3; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Ошибка: введено не целое число. Попробуйте еще раз.");
                    i--;
                }
            }

            Array.Sort(numbers);
            Console.WriteLine(
                $"Результат сортировки чисел в порядке возрастания: {numbers[0]} {numbers[1]} {numbers[2]}");
        }
    }
}