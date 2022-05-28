/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
    Console.WriteLine();
}


Console.Write("Введите количество элементов массива - ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[arrayLength];

FillArray(array1);

WriteNumber(array1);

int arrayCount = -1;
if (arrayLength % 2 == 0) // Определение длины массива-2 для вывода значений произведений
{
    arrayCount = arrayLength / 2;
    Console.WriteLine($"Количество элементов для вывода произведений пар чисел = {arrayCount}");
}
else
{
    arrayCount = arrayLength / 2 + 1;
    Console.WriteLine($"Количество элементов для вывода произведений пар чисел = {arrayCount}");
}


int[] array2 = new int[arrayCount];  // Заполнение массива-2
if (arrayLength % 2 == 1)
{
    for (int i = 0; i < arrayCount; i++)
    {
        array2[i] = array1[i] * array1[arrayLength - 1 - i];
    }
    array2[arrayCount - 1] = array1[arrayLength / 2]; // Определение среднего элемента массива
}
else
{
    for (int i = 0; i < arrayCount; i++)
    {
        array2[i] = array1[i] * array1[arrayLength - 1 - i];
    }
}

WriteNumber(array2);
