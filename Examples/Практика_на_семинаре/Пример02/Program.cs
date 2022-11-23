// Задайте двумерный массив размера m на n,
// каждый элент которого находится по формуле A = m+n
// Выведите полученный массив на экран.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
