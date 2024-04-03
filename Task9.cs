// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дан массив преобразовать его, так чтобы последний поменялась с первой предпоследний с вторым и т.д.

using System;

namespace Exercise_1
{
    public static class Task9
    {
        public static void Complete()
        {
            int[] arr = {1, 2, 3, 4, 5, 6};
            int length = arr.Length;

            for (int i = 0; i < length / 2; i++)
            {
                (arr[i], arr[length - 1 - i]) = (arr[length - 1 - i], arr[i]);
            }

            foreach (var vaiable in arr)
            {
                Console.Write($"{vaiable} ");
            }
        }
    }
}