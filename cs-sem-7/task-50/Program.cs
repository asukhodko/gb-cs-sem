// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] arr = new int[,]{
    {1, 3, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int i = ReadInt("Введите строку: ");
int j = ReadInt("Введите столбец: ");

Print2DArray(arr);

if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1))
{
    Console.WriteLine("Такого элемента нет.");
    return;
}

Console.WriteLine(arr[i, j]);


int ReadInt(string message)
{
    for (; ; )
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        Console.WriteLine("Ошибка ввода!");
    }
}

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

/*
asukhodko@MBP-Aleksandr task-50 % dotnet run
Введите строку: 2
Введите столбец: 17
1 3 7 2 
5 9 2 3 
8 4 2 4 
Такого элемента нет.
asukhodko@MBP-Aleksandr task-50 % dotnet run
Введите строку: 0
Введите столбец: 2
1 3 7 2 
5 9 2 3 
8 4 2 4 
7
*/
