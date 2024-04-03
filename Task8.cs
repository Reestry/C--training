// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дан одномерный массив отсортировать отрицательные элементы. ([4, -1, 1, -2] → [4, -2, 1, -1])

using System;
using System.Collections.Generic;

namespace Exercise_1
{
    public static class Task8
    {
        public static void Complete()
        {
            int[] arr = {4, -1, 1, -2, 9, -5, -7, -3, 5};
            Sorting(ref arr);

            foreach (var variable in arr)
            {
                Console.Write($"{variable} ");
            }

            void Sorting(ref int[] nums)
            {
                var output = new List<int>();
                foreach (var variable in nums)
                {
                    if (variable < 0)
                        output.Add(variable);
                }

                output.Sort();

                var count = 0;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < 0)
                    {
                        nums[i] = output[count];
                        count++;
                    }
                }
            }
        }
    }
}