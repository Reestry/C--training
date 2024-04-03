// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дан двумерный массив поменять местами элементы, расположенные на главной диагонали с противоположной диагонально.

using System;

namespace Exercise_1
{
    public static class Task13
    {
        public static void Complete()
        {
            int[,] array = new int[,]
            {
                {1, 0, 0, 2},
                {0, 1, 2, 0},
                {0, 2, 1, 0},
                {2, 0, 0, 1}
            };
            var column = 0;
            var arraySize = array.GetUpperBound(0);

            Console.WriteLine("Массив до изменений");
            PrintArray();

            for (var lines = 0; lines <= arraySize; lines++)
            {
                (array[lines, column], array[lines, arraySize - column]) =
                    (array[lines, arraySize - column], array[lines, column]);

                column++;
            }

            Console.WriteLine("Массив после изменений");
            PrintArray();

            void PrintArray()
            {
                for (var lines = 0; lines <= arraySize; lines++)
                {
                    for (var columns = 0; columns <= arraySize; columns++)
                        Console.Write(array[lines, columns] + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}