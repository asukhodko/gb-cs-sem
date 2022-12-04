// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");

double[,] arr = new double[m, n];
Fill2DArrayWithRandoms(ref arr);
Print2DArray(arr);


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

void Fill2DArrayWithRandoms(ref double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble();
        }
    }
}

void Print2DArray(double[,] arr)
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
asukhodko@MBP-Aleksandr task-47 % dotnet run
Введите m: 3
Введите n: 4
0,4088378765653059 0,744655030098133 0,1651995057417559 0,6297620827179116 
0,3612896632292282 0,827520257711518 0,955714070862616 0,7352816039566086 
0,30068742389859193 0,14632009510530042 0,5424066595063901 0,6934258449223245 
*/
