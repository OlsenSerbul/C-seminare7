// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int[,] array = new int[3, 5];
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
Console.WriteLine();

int[] StringSumArray( int[,] array)  // метод: линейный массив сумм всех строк
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       int sum = 0;

         for (int j = 0; j < array.GetLength(1); j++)
         {
            sum += array[i, j];
         }
         newArray[i] = sum;
    }
    return newArray;
}
 int[] newArray = StringSumArray(array);
 Console.WriteLine(String.Join(",", newArray));

 int minSum = newArray[0];      // в линейном массиве ищем минимальную сумму и ее индекс
 int minIndex = 0;
 for (int i = 0; i < newArray.Length; i++)
 {
    if( newArray[i] <= minSum )
    {
        minSum = newArray[i]; 
        minIndex = i; 
    } 
 }
 Console.WriteLine($"{minIndex + 1} строка содержит минимальную сумму {minSum}");
 

