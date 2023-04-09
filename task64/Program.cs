﻿// Задача 64: Выполнить с помощью рекурсии.Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"N = {N} -> {PrintNumbers(N, 1)}");
//-------------------метод---------------
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}