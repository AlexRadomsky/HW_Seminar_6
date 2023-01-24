/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

Console.Write("Enter the elements separated by a space: ");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = numbers.Count(x => x > 0);
Console.Write($"Number of elements > 0: {count}");