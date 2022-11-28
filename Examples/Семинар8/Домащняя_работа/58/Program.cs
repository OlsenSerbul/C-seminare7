// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[4,4];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(1, 10);
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrix2 = new int[4,4];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(1, 10);
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for( int i = 0; i < matrix1.GetLength(0); i++)
    {
        for( int j = 0; j < matrix2.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}
int[,] result = MultiplicationMatrix(matrix1, matrix2);
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}