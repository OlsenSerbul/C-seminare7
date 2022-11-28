// Задайте двумерный массив из целых чисел.Напишите программу
// которая запишет нулями строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.
int[,] array = new int[4, 4];
// заполняем массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
// поиск наименьшего элемента массива и его индексов
int minIndexI = 0;
int minIndexJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (array[minIndexI, minIndexJ] > array[i, j])
        {
            minIndexI = i;
            minIndexJ = j;
        }
    }
}
Console.WriteLine($"минимальный " + array[minIndexI, minIndexJ]);
// заполняем 0 строки и столбцы
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, minIndexJ] = 0;
        array[minIndexI, j] = 0;
    }
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
