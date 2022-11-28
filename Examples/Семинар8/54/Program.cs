// Задайте двумерный массив. Напишите программу, которая
//  поменяет местами первую и последнюю стоку массива.

int[,] array = new int[5, 5];
void FillArray (int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray( int[,] array)
{
    for( int i = 0 ; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            
                int temp = array[0, j];
                array[0, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
Console.WriteLine();
ChangeArray(array);