// Задача 68: Выполнить с помощью рекурсии. Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"m = {m}, n = {n} -> {Function(m, n)}");

//------------метод------------
int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Function(m - 1, 1);
    }
    else
    {
        return (Function(m - 1, Function(m, n - 1)));
    }
}