Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(-9, 10);
        index++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
        
    }
    
}
Console.WriteLine();
int SummUnder(int[] arr)
{
    int underZero = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 0) underZero = underZero + arr[i];
    }
    return underZero;
}

int SummUp(int[] arr)
{
    int upZero = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) upZero = upZero + arr[i];
    }
    return upZero;
}
FillArray(array);
PrintArray(array);

Console.WriteLine();
int sumUnder = SummUnder(array);
int sumUp = SummUp(array);

Console.WriteLine($"Сумма отрицательных элементов массива = {sumUnder}");
Console.WriteLine($"Сумма положительных элементов массива = {sumUp}");

// Создание массива

// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] array = new int[size];
// var rnd = new Random();

// for (int i = 0; i < size; i++)
// {
// array[i] = rnd.Next(min, max + 1);
// }
// return array;
// }

// Печать массива

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if (i < array.Length - 1) Console.Write($"{array[i]}, ");
// else Console.Write($"{array[i]}");
// }
// Console.WriteLine("]");
// }

// int GetSumPositiveElem(int[] array)
// {
// int sumPositive = default;

// for (int i = 0; i < array.Length; i++)
// if (array[i] > 0) sumPositive += array[i];

// return sumPositive;
// }
// Андрей Булгаков: int GetSumNegativeElem(int[] array)
// {
// int sumNegative = default;

// for (int i = 0; i < array.Length; i++)
// if (array[i] < 0) sumNegative += array[i];

// return sumNegative;
// }

// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// int sumPositive = GetSumPositiveElem(arr);
// int sumNegative = GetSumNegativeElem(arr);
// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");

// double[] resArr = new double[num];
// var rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array1[i] = rnd.NextDouble() * (max - min) + min;
// }