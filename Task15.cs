// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дана строка, посчитать количество слов.

using System;

namespace Exercise_1
{
    public static class Task15
    {
        public static void Complete()
        {
            var text = "text kov hfghhfh jfjdj jfdjfjd jdjf jdfjdjuwew ";
            Console.WriteLine($"Количество слов: { text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length}");
        }
    }
}