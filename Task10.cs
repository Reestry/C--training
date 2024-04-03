// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Exercise_1
{
    public static class Task10
    {
        public static void Complete()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sumM = 0;
            var sumN = 0;

            Console.WriteLine("Введите M");
            if (!int.TryParse(Console.ReadLine(), out var m))
            {
                Console.WriteLine("Ошибка: число не соответствует требованиям.");
            }

            Console.WriteLine("Введите N");
            if (!int.TryParse(Console.ReadLine(), out var n))
            {
                Console.WriteLine("Ошибка: число не соответствует требованиям.");
            }

            foreach (var variable in arr)
            {
                if (variable < n)
                    sumN += variable;

                if (variable > m)
                    sumM += variable;
            }

            Console.WriteLine($"Сумма чисел, которые больше M: {sumM}");
            Console.WriteLine($"Сумма чисел, которые больше N: {sumN}");
        }
    }
}