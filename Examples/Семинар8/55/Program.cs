// задайте двумерный массив. Напишите программу, которая
// поменяет местами строки со столбцами.
int[,] array = new int[3, 3];
for( int i = 0; i < array.GetLength(0); i++)
{
    for( int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j ] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// создаем метод для замены строк на столбцы, сщздаем новый массив, такой же по размерности, меняем значения в новом массиве
int[,] ChengeArray(int[,] array)
{
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
    for( int i = 0; i < newarray.GetLength(0); i++)
    {
        for( int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[j, i] = array[i, j];
        }
    }
    return newarray;
}
int[,] newarray = ChengeArray(array);
// выводим новый массив на консоль
for( int i = 0; i < newarray.GetLength(0); i++)
{
    for( int j = 0; j < newarray.GetLength(1); j++)
    {
        Console.Write(newarray[i, j] + " ");
    }
    Console.WriteLine();
}
