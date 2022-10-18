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