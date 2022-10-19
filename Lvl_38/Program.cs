Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];

void FillArray(double[] col, int min, int max)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        index++;
    }
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

void Difference(double[] arr)
{
    int maxID = default;
    int minID = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[minID] >= arr[i]) minID = i;
        if (arr[maxID] <= arr[i]) maxID = i;
    }
    double diff = Math.Round(arr[maxID] - arr[minID], 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");
}

FillArray(array, 10, 99);
PrintArray(array);
Difference(array);