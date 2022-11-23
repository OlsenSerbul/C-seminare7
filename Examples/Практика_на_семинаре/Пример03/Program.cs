// Задайте двумерный массив. Найдите элементы у которых
// оба индекса четные, и замените эти элементы на их квадраты.

Console.Write("Введите количество строк:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

