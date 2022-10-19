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
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
        
    }
    
}

int SummNumbers(int[] arr)
{
    int sum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

FillArray(array);
PrintArray(array);
int resSumm = SummNumbers(array);
Console.WriteLine($"Сумма нечетных элементов массива равна: {resSumm}");
