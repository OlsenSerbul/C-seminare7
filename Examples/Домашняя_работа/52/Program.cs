// Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения 
// массива случайными числами. Напишите метод для поиска среднего арифметического значения каждого столбца.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();

void FindSA(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double SA = 0;
            double sum = 0;
            
            for (int k = 0; k < m; k++)
            {
                sum = sum + array[k, j];
            }
            SA = sum / m ; 
            Console.Write(Math.Round(SA, 2) + " ");
        } 
        return;   
    }  
}

FindSA(array, m, n);
