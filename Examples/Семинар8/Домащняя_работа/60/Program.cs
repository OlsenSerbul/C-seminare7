// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] array = new int[2, 2, 2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int number = new Random().Next(21, 89);
            int number1 = new Random().Next(13, 18);
            array[i, j, k] = new Random().Next(10, 20) + number - number1;
            Console.Write(" " + array[i, j, k] + $"({i},{j},{k})");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();