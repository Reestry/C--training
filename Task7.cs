// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Exercise_1
{
    public static class Task7
    {
        public static void Complete()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var evenElement = 0;
            var oddElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    evenElement += arr[i];
                else
                    oddElement += arr[i];
            }

            Console.WriteLine($"Сумма четных элементов: {evenElement}");
            Console.WriteLine($"Сумма нечетных элементов: {oddElement}");
        }
    }
}