// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = GetRandomDoubles(5, -100, 100);
FindMinMax(arr, out double min, out double max);
double diff = max - min;

PrintArray(arr);
Console.Write(" -> ");
Console.WriteLine(diff);

double[] GetRandomDoubles(int size, int min, int max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (max - min) + min;
    }
    return result;
}

void FindMinMax(double[] arr, out double min, out double max)
{
    if (arr.Length == 0)
    {
        min = 0;
        max = 0;
        return;
    }
    min = arr[0];
    max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
}

void PrintArray(double[] arr)
{
    Console.Write($"[{String.Join(", ", arr)}]");
}

/*
asukhodko@MBP-Aleksandr task-38 % dotnet run
[31,420029951545928, 63,660338860063916, -28,464193615091943, -18,80068121770688, -88,42224788907677] -> 152,0825867491407
asukhodko@MBP-Aleksandr task-38 % dotnet run
[46,04870166816997, 47,708680237744346, 95,48233561115777, -71,20083621280007, 91,79800887689146] -> 166,68317182395782
asukhodko@MBP-Aleksandr task-38 % dotnet run
[22,062977232130663, -88,41712264325179, -93,69406659063131, -18,723590194207844, -37,39913600037874] -> 115,75704382276197
*/
