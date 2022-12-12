// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] m1 = new int[,] {
    { 2, 4 },
    { 3, 2 },
};

int[,] m2 = new int[,] {
    { 3, 4 },
    { 3, 3 },
};

int[,] m3 = MatrixMul(m1, m2);

Print2DArray(m1);
Print2DArray(m2);
Print2DArray(m3);

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

int[,] MatrixMul(int[,] m1, int[,] m2)
{
    int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];

    for (int r = 0; r < m3.GetLength(0); r++)
        for (int c = 0; c < m3.GetLength(1); c++)
        {
            m3[r, c] = m1[r, 0] * m2[0, c] + m1[r, 1] * m2[1, c];
        }

    return m3;
}

/*
asukhodko@MBP-Aleksandr task-58 % dotnet run
2 4 
3 2 

3 4 
3 3 

18 20 
15 18 
*/
