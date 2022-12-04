// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = GetRandomArray(4, 100, 999);
int evens = EvenCount(arr);

PrintArray(arr);
Console.Write(" -> ");
Console.WriteLine(evens);

int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int EvenCount(int[] arr)
{
    int evens = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            evens++;
    }
    return evens;
}

void PrintArray(int[] arr)
{
    Console.Write($"[{String.Join(", ", arr)}]");
}

/*
asukhodko@MBP-Aleksandr task-34 % dotnet run
[565, 568, 221, 282] -> 2
asukhodko@MBP-Aleksandr task-34 % dotnet run
[193, 404, 266, 557] -> 2
asukhodko@MBP-Aleksandr task-34 % dotnet run
[352, 852, 174, 139] -> 3
*/