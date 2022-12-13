// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] arr = new int[4, 4];
FillBySpiral(arr);
Print2DArray(arr);

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillBySpiral(int[,] arr)
{
    int top = 0, bottom = arr.GetLength(0) - 1;
    int left = 0, right = arr.GetLength(1) - 1;
    int r = 0, c = 0;
    int dir = 1; // 1 right, 2 down, 3 left, 4 up
    int n = 1;

    while (top <= bottom && left <= right)
    {
        arr[r, c] = n;
        n++;

        if (dir == 1) // right
        {
            if (c < right)
                c++;
            else
            {
                dir = 2; // down
                r++;
                top++;
            }
        }
        else if (dir == 2) // down
        {
            if (r < bottom)
                r++;
            else
            {
                dir = 3; // left
                c--;
                right--;
            }
        }
        else if (dir == 3) // left
        {
            if (c > left)
                c--;
            else
            {
                dir = 4; // up
                r--;
                bottom--;
            }
        }
        else if (dir == 4) // up
        {
            if (r > top)
                r--;
            else
            {
                dir = 1; // right
                c++;
                left++;
            }
        }
    }
}

/*
asukhodko@MBP-Aleksandr task-62 % dotnet run
1 2 3 4 
12 13 14 5 
11 16 15 6 
10 9 8 7 
*/
