// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void numbers(int m, int n)
{
    if (m > n)
        return;
{
    Console.Write($"{m} ");
}
numbers(m + 1, n);
}

Console.Clear();
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
numbers(m, n);
