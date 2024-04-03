// Copyright (c) 2012-2023 FuryLion Group. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var humans = new List<Human>();

            while (true)
            {
                Console.WriteLine("1 - Добавить человека \r\n" +
                                  "2 - Редактировать поле \r\n" +
                                  "3 - Вывести поля  \r\n" +
                                  "4 - Удалить поля \r\n" +
                                  "5 - Вывод информации о всех людях \r\n" +
                                  "6 - Выход");
                var menuIndex = int.Parse(Console.ReadLine() ?? string.Empty);

                switch (menuIndex)
                {
                case 1:
                    Console.WriteLine("1 - Добавить информацию о новом студенте.\r\n" +
                                      "2 - Добавить информацию о новом работнике.\r\n" +
                                      "3 - Добавить информацию о новом водителе");
                    menuIndex = int.Parse(Console.ReadLine() ?? string.Empty);

                    switch (menuIndex)
                    {
                    case 1:
                        humans.Add(new Student());
                        humans[humans.Count() - 1].Edit();
                        break;
                    case 2:
                        humans.Add(new Employee());
                        humans[humans.Count() - 1].Edit();
                        break;
                    case 3:
                        humans.Add(new Driver());
                        humans[humans.Count() - 1].Edit();
                        break;
                    }

                    break;
                case 2:
                    if (!humans.Any())
                        Console.WriteLine("Записей не существует");
                    else
                    {
                        Console.WriteLine($"Введите номер записи от 1 до {humans.Count()}");
                        humans[int.Parse(Console.ReadLine() ?? string.Empty) - 1].Edit();
                    }

                    break;
                case 3:
                    if (!humans.Any())
                        Console.WriteLine("Записей не существует");
                    else
                    {
                        Console.WriteLine($"Введите номер записи от 1 до {humans.Count()}");
                        humans[int.Parse(Console.ReadLine() ?? string.Empty) - 1].Display();
                    }

                    break;
                case 4:
                    if (!humans.Any())
                        Console.WriteLine("Информации о водителях не существует");
                    else
                    {
                        Console.WriteLine($"Введите номер водителя от 1 до {humans.Count()}");
                        humans.Remove(humans[int.Parse(Console.ReadLine() ?? string.Empty) - 1]);
                    }

                    break;
                case 5:
                    Console.WriteLine("");
                    foreach (var variable in humans)
                    {
                        variable.Display();
                        Console.WriteLine("");
                    }

                    break;
                case 6:
                    return;
                }
            }
        }
    }
}