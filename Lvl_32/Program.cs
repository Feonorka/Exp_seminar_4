
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
    Console.WriteLine();
}
void SwitchNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
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
    Console.WriteLine();
}

Console.WriteLine();
FillArray(array);
Console.WriteLine("До:");
PrintArray(array);
SwitchNum(array);
Console.WriteLine("После:");
PrintArray(array);