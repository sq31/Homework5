/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] arrayCreate)
{
    Console.WriteLine("Введите диапазон чисел для заполнения массива:");
    Console.Write("От - ");
    int from = Convert.ToInt32(Console.ReadLine());
    Console.Write("До - ");
    int to = Convert.ToInt32(Console.ReadLine());
    if (from < to)
    {
        for (int index = 0; index < arrayCreate.Length; index++)
        {
            arrayCreate[index] = new Random().Next(from, to);
        }
    }
    else
    {
        for (int index = 0; index < arrayCreate.Length; index++)
        {
            arrayCreate[index] = new Random().Next(to, from);
        }
    }
}

void WriteNumber(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
}

Console.Write("Введите количество элементов массива - ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[arrayLength];
FillArray(array1);

int FindChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

WriteNumber(array1);
int sum = FindChet(array1);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");