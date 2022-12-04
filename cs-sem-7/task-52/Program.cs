// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] arr = new int[,]{
    {1, 3, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Print2DArray(arr);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int c = 0; c < arr.GetLength(1); c++)
{
    double avg = ColumnAvg(arr, c);
    Console.Write($"{avg}; ");
}
Console.WriteLine();


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
}

double ColumnAvg(int[,] arr, int c)
{
    double a = 0;
    int cnt = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        a += arr[i, c];
        cnt++;
    }
    return a / cnt;
}

/*
asukhodko@MBP-Aleksandr task-52 % dotnet run
1 3 7 2 
5 9 2 3 
8 4 2 4 
Среднее арифметическое каждого столбца: 4,666666666666667; 5,333333333333333; 3,6666666666666665; 3; 
*/
