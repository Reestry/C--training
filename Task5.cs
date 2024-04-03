// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Реализовать метод, который получает число X и возвращает все четные числа в
// диапазоне от 0..X (X=10 → 0, 2, 4, 6, 8, 10).

using System;

namespace Exercise_1
{
    public static class Task5
    {
        public static void Complete()
        {
            Console.WriteLine("Введите X");
            if (!int.TryParse(Console.ReadLine(), out var x))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            for (var i = 0; i <= x; i++)
                if (i % 2 == 0)
                    Console.Write($"{i} ");
        }
    }
}