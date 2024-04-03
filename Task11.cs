// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;

namespace Exercise_1
{
    public static class Task11
    {
        public static void Complete()
        {
            const int lines = 4;
            const int columns = 4;
            var arr = new[,] {{1, 1, 1, 1}, {2, 2, 2, 2}, {3, 3, 3, 3}, {4, 4, 4, 4}};

            for (var i = 0; i < lines; i += 2)
            {
                if (i + 1 < lines)
                {
                    for (var j = 0; j < columns; j++)
                    {
                        (arr[i, j], arr[i + 1, j]) = (arr[i + 1, j], arr[i, j]);
                    }
                }
            }

            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}