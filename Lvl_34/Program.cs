Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
        
    }
    
}

int CountNumbers(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
PrintArray(array);
int resCount = CountNumbers(array);
Console.WriteLine($"Количество четных чисел равно: {resCount}");