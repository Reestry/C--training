// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Exercise_1
{
    public static class Task6
    {
        public static void Complete()
        {
            Console.WriteLine("Введите X");
            if (!int.TryParse(Console.ReadLine(), out var x))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            Console.Write("Совершенные числа в диапазоне 0..{0}: ", x);
            for (var i = 1; i <= x; i++)
            {
                var sumDivisors = 0;
                for (var j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sumDivisors += j;
                }

                if (sumDivisors == i)
                    Console.Write("{0} ", i);
            }
        }
    }
}