// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

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

int[] Expo(int[] arr)
{
    int numRes = arr.Length / 2;
    if (arr.Length % 2 == 1) numRes++;
    
    int[] resArr = new int[numRes];

    for (int i = 0; i < (arr.Length / 2); i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) resArr[numRes - 1] = arr[numRes - 1];
    return resArr;
}

FillArray(array, 1, 10);

PrintArray(array);
int[] emptyArr = Expo(array);

PrintArray(emptyArr);