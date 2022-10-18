// Задать массив
// Задать число
// Определить входит ли оно туда
Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
Console.Write("Введите искомое число: ");
int numFind = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(1, 10);
        index++;
    }
}

void NumFinder(int[] arr, int find)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            res = true;
            break;
        }
    }
    if (res == true) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
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

FillArray(array);
PrintArray(array);

NumFinder(array, numFind);
