// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = GetRandomArray(4, -100, 100);
int sum = SummOdd(arr);

PrintArray(arr);
Console.Write(" -> ");
Console.WriteLine(sum);

int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int SummOdd(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            result += arr[i];
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write($"[{String.Join(", ", arr)}]");
}

/*
asukhodko@MBP-Aleksandr task-36 % dotnet run
[31, 39, 78, 43] -> 82
asukhodko@MBP-Aleksandr task-36 % dotnet run
[-100, 29, 21, -38] -> -9
*/
