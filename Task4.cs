// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Получить сумму первых N чисел с шагом M от числа X (X=10 N=5 M=2 → 10+12+14+16+18=70).

using System;

namespace Exercise_1
{
    public static class Task4
    {
        public static void Complete()
        {
            var output = 0;

            Console.WriteLine("Введите X");
            if (!int.TryParse(Console.ReadLine(), out var x))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            Console.WriteLine("Введите N");
            if (!int.TryParse(Console.ReadLine(), out var n))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            Console.WriteLine("Введите M");
            if (!int.TryParse(Console.ReadLine(), out var m))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            for (var i = 0; i < n; i++)
                output += x + i * m;

            Console.WriteLine(output.ToString());
        }
    }
}