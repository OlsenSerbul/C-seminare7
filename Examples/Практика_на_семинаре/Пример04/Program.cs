// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.Write("Введите размерность стороны :  ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;


int[,] array = new int[m, n];
int sum = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        if (i == j)
        {
            sum = sum + array[i, j];
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов по главной диагонали = {sum}");

