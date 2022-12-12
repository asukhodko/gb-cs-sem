// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] arr = new int[,] {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

Print2DArray(arr);
int r = FindLeastRow(arr);
Console.WriteLine($"Строка {r}:");
PrintRow(arr, r);

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindLeastRow(int[,] arr)
{
    int minSum = 0;
    int minSumRow = -1;
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        int sum = 0;
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            sum += arr[r, c];
        }
        if (minSumRow < 0 || sum < minSum)
        {
            minSum = sum;
            minSumRow = r;
        }
    }
    return minSumRow;
}

void PrintRow(int[,] arr, int r)
{
    for (int c = 0; c < arr.GetLength(1); c++)
    {
        Console.Write($"{arr[r, c]} ");
    }
    Console.WriteLine();
}

/*
asukhodko@MBP-Aleksandr task-56 % dotnet run
1 4 7 2 
5 9 2 3 
8 4 2 4 
5 2 6 7 

Строка 0:
1 4 7 2 
*/
