// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] col, int minN, int maxN)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(minN, maxN);
        index++;
    }
}

// Печать массива

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void SearchSumm(int[] array, int min, int max)
{
    int resSum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max) resSum = resSum + array[i];
    }
    Console.WriteLine($"Сумма элементов массива попадающих в интервал от {min} до {max} равна {resSum}");
}


FillArray(array, 1, 124);
PrintArray(array);
SearchSumm(array, 10, 99);