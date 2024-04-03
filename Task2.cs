// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

//С клавиатуры вводится число, вывести его в обратном порядке (358 → 853).

using System;

namespace Exercise_1
{
    public static class Task2
    {
        public static void Complete()
        {
            var output = 0;
            
            Console.WriteLine("Введите целое число");
            if (!int.TryParse(Console.ReadLine(), out var number))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");

            while (number > 0) 
            {
                output = output * 10 + number % 10;
                number /= 10;
            }
            
            Console.WriteLine("Число в обратном порядке: " + output);
        }
    }
}
