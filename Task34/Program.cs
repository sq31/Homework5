/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


void FillArray(int[] arrayCreate)
{
    for (int index = 0; index < arrayCreate.Length; index++)
    {
        arrayCreate[index] = new Random().Next(100, 999);
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
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

WriteNumber(array1);
int count = FindChet(array1);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {count}");