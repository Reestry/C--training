// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дана строка, посчитать количество слов, которые начинаются на букву "K".

using System;

namespace Exercise_1
{
    public static class Task18
    {
        public static void Complete()
        {
            var input = "Колышек кот капуста кентавр солнце аккуратность";
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Строка пуста.");
                return;
            }
            
            var words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var count = 0;
            foreach (var word in words)
            {
                if (word.StartsWith("к") || word.StartsWith("К"))
                    count++;
            }
            
            Console.WriteLine($"Количество подходящих слов: {count}");
        }
    }
}