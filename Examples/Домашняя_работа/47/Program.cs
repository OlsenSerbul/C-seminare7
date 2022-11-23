// Запросите от пользователя размерности двумерного массива. Напишите метод
// для заполнения массива случайными вещественными числами. Напишите метод для вывода 
// массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.

Console.Write("Введите количество строк:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void FillArray(double[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(1, 10);
        }
    }
    return;
}
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array, m, n);
PrintArray(array);