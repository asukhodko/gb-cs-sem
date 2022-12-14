// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int N = ReadInt("Введите N (целое): ");
DumpDownN(N);

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

void DumpDownN(int N)
{
    Console.Write($"{N} ");
    if (N > 1)
        DumpDownN(N - 1);
    else
        Console.WriteLine();
}

/*
asukhodko@MBP-Aleksandr task-64 % dotnet run
Введите N (целое): 5
5 4 3 2 1 
asukhodko@MBP-Aleksandr task-64 % dotnet run
Введите N (целое): 8
8 7 6 5 4 3 2 1 
*/
