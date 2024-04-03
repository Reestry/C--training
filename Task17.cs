// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

// Дана строка, поменять все символы "C" на "E".

using System;

namespace Exercise_1
{
    public static class Task17
    {
        public static void Complete()
        {
            var text = "CCCCCCCCCCCCCCCCDDDDDDDCCCC";
            Console.Write(text.Replace('C', 'E'));
        }
    }
}