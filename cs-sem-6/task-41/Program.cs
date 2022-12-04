// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int M = ReadInt("Введите число M: ");
int[] arr = ReadIntArray(M);
int positives = CountPositives(arr);
Console.WriteLine($"Чисел больше 0: {positives}");

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

int[] ReadIntArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = ReadInt($"Введите {i + 1}-е целое число: ");
    }
    return result;
}

int CountPositives(int[] arr)
{
    int result = 0;
    foreach (int i in arr)
    {
        if (i > 0)
            result++;
    }
    return result;
}

/*
asukhodko@MBP-Aleksandr task-41 % dotnet run
Введите число M: 5
Введите 1-е целое число: 0
Введите 2-е целое число: 7
Введите 3-е целое число: 8
Введите 4-е целое число: -2
Введите 5-е целое число: -2
Чисел больше 0: 2
asukhodko@MBP-Aleksandr task-41 % dotnet run
Введите число M: 5
Введите 1-е целое число: 1
Введите 2-е целое число: -7
Введите 3-е целое число: 567
Введите 4-е целое число: 89
Введите 5-е целое число: 223
Чисел больше 0: 4
*/
