// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = ReadInt("Введите M: ");
int N = ReadInt("Введите N: ");
int sum = SumInterval(M, N);
Console.WriteLine(sum);

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

int SumInterval(int M, int N)
{
    if (M == N)
        return M;
    if (M + 1 == N)
        return M + N;
    return M + N + SumInterval(M + 1, N - 1);
}

/*
asukhodko@MBP-Aleksandr task-66 % dotnet run   
Введите M: 1
Введите N: 15
120
asukhodko@MBP-Aleksandr task-66 % dotnet run
Введите M: 4
Введите N: 8
30
*/
