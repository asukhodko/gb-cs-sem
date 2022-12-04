// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = GetRandomArray(8);
PrintArray(array);

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

/*
asukhodko@MBP-Aleksandr task-29 % dotnet run
[1463420462, 812665638, 664331742, 1925411412, 1638622781, 819625195, 508823444, 1181478842]
*/
