// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int a = Ackermann(m, n);
Console.WriteLine(a);

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

int Ackermann(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}

/*
asukhodko@MBP-Aleksandr task-68 % dotnet run
Введите m: 2
Введите n: 3
9
asukhodko@MBP-Aleksandr task-68 % dotnet run
Введите m: 3
Введите n: 2
29
*/
