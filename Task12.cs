// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дан двумерный массив получить максимальные элемента каждого столбца.

using System;

namespace Exercise_1
{
    public static class Task12
    {
        public static void Complete()
        {
            var array = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var rows = array.GetLength(0);
            var cols = array.GetLength(1);

            var maxValues = new int[cols];

            for (var j = 0; j < cols; j++)
            {
                var maxValue = int.MinValue;
                for (var i = 0; i < rows; i++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }
                }

                maxValues[j] = maxValue;
            }

            for (var j = 0; j < cols; j++)
            {
                Console.WriteLine($"Максимальный элемент в столбце {j} равен {maxValues[j]}");
            }
        }
    }
}