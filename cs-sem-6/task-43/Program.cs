// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = ReadDouble("Введите b1: ");
double k1 = ReadDouble("Введите k1: ");

double b2 = ReadDouble("Введите b2: ");
double k2 = ReadDouble("Введите k2: ");

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются.");
}
else
{
    double x = CalcCrosslinesX(k1, k2, b1, b2);
    double y = CalcLineY(x, k1, b1);

    Console.WriteLine($"({x}; {y})");
}

double ReadDouble(string message)
{
    for (; ; )
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double result))
            return result;
        Console.WriteLine("Ошибка ввода!");
    }
}

double CalcCrosslinesX(double k1, double k2, double b1, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double CalcLineY(double x, double k, double b)
{
    return k * x + b;
}
/*
asukhodko@MBP-Aleksandr task-43 % dotnet run
Введите b1: 2
Введите k1: 5
Введите b2: 4
Введите k2: 9
(-0,5; -0,5)
*/
