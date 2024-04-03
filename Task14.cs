// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дана строка, посчитать количество символов "A".

using System;

namespace Exercise_1
{
    public static class Task14
    {
        public static void Complete()
        {
            var str = "ДанA строка A ";
            var symb = 'A';
            var freq = 0;

            foreach (var c in str)
            {
                if (c == symb)
                    freq++;
            }

            Console.WriteLine(freq);
        }
    }
}