// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Реализовать метод вычисляющий факториал из числа введенного с клавиатуры (5 → 120).

using System;

namespace Exercise_1
{
    public static class Task3
    {
        public static void Complete()
        {
            var output = 1;
            
            Console.WriteLine("Введите целое число");
            if (!int.TryParse(Console.ReadLine(), out var number))
                Console.WriteLine("Ошибка: число не соответствует требованиям.");
            
            for (int i = 1; i <= number; i++) 
                output *= i;
            
            Console.WriteLine($"Факториал вашего числа: {output}");
        }
    }
}