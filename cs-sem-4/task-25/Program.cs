// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A = ReadInt("Введите число A (целое): ");
int B = ReadPositiveInt("Введите число B (целое положительное): ");

int result = Pow(A, B);

Console.WriteLine($"{A}, {B} -> {result}");

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

int ReadPositiveInt(string message)
{
    for (; ; )
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int result))
            if (result >= 0)
                return result;
        Console.WriteLine("Ошибка ввода!");
    }
}

int Pow(int A, int B)
{
    int result = 1;
    for (; B > 0; B--)
        result *= A;
    return result;
}

/*
asukhodko@MBP-Aleksandr task-25 % dotnet run
Введите число A (целое): 3
Введите число B (целое положительное): 5
3, 5 -> 243
asukhodko@MBP-Aleksandr task-25 % dotnet run
Введите число A (целое): 2
Введите число B (целое положительное): 4
2, 4 -> 16
*/