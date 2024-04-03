// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дана строка, перевернуть ее (компьютер → ретюьпмок).

using System;
using System.Linq;

namespace Exercise_1
{
    public static class Task16
    {
        public static void Complete()
        {
            var str = "Добрый день";
            Console.WriteLine(str.Reverse().ToArray());
        }
    }
}