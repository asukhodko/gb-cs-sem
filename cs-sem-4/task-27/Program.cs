// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int A = ReadInt("Введите целое число: ");
int result = CalcDigitsSum(A);
Console.WriteLine($"{A} -> {result}");

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

int CalcDigitsSum(int A)
{
    if(A < 0)
        A = -A;
    int result = 0;
    while(A > 0)
    {
        result += A % 10;
        A = A / 10;
    }
    return result;
}

/*
asukhodko@MBP-Aleksandr task-27 % dotnet run
Введите целое число: 452
452 -> 11
asukhodko@MBP-Aleksandr task-27 % dotnet run
Введите целое число: 82
82 -> 10
asukhodko@MBP-Aleksandr task-27 % dotnet run
Введите целое число: 9012
9012 -> 12
*/