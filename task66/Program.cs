// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите М: ");
int M = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"M = {M}; N = {N} -> {Sum(M, N)}");

//---------------метод-----------
int Sum(int start, int end)
{
    if (start == end) return start;
    return (start + Sum(start + 1, end));
}