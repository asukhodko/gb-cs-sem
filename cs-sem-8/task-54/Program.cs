// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = new int[,] {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

Print2DArray(arr);
SortLinesDesc(arr);
Print2DArray(arr);

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

void SortLinesDesc(int[,] arr)
{
    for (int r = 0; r < arr.GetLength(0); r++)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int i = c + 1; i < arr.GetLength(1); i++)
            {
                if (arr[r, i] > arr[r, c])
                {
                    int t = arr[r, i];
                    arr[r, i] = arr[r, c];
                    arr[r, c] = t;
                }
            }
        }
    }
}

/*
asukhodko@MBP-Aleksandr task-54 % dotnet run
1 4 7 2 
5 9 2 3 
8 4 2 4 

7 4 2 1 
9 5 3 2 
8 4 4 2 
*/