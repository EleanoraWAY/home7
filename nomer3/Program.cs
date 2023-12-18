//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using static System.Console;
int[] numbers = { 5, 10, 15, 20, 30, 34 };

void ReverseArray(int[] array, int FirstElement, int LastElement)
{
    if (FirstElement < LastElement)
{
int temp = array[FirstElement];
array[FirstElement] = array[LastElement];
array[LastElement] = temp;
ReverseArray(array, FirstElement + 1, LastElement - 1);
}
}
ReverseArray(numbers, 0, numbers.Length - 1);

foreach (int i in numbers)
{
    Write($"{i}  ");
}