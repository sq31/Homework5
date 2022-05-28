/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


void CreateArray(double[] arrayCreate)
{
    for (int index = 0; index < arrayCreate.Length; index++)
    {
        arrayCreate[index] = Math.Round((new Random().NextDouble() * 100), 3);
    }
}

void PrintArray(double[] array)
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
double[] array1 = new double[arrayLength];

CreateArray(array1);

PrintArray(array1);

// Определение min и max в массиве
double minArray = array1[0];
double maxArray = array1[0];

for (int i = 0; i < arrayLength; i++)
{
    if (array1[i] < minArray)
    {
        minArray = array1[i];
    }
    else if (array1[i] > maxArray)
    {
        maxArray = array1[i];
    }
}

Console.WriteLine($"Разница между минимальным {minArray} и максимальным {maxArray}");
Console.WriteLine($"элементом массива равна {Math.Round((maxArray - minArray), 3)}");
