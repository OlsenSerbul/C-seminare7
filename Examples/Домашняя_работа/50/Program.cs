// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного 
// массива и возвращать значение элемента, стоящего в этой позиции. Если такой позиции в массиве нет,
// то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

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
Console.Write("Введите позицию по строке :  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию по столбцу :  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[10, 10];
FillArray(array);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == m && j == n)
        {
            Console.WriteLine($"По заданным параметрам найден элемент = {array[i, j]}");
        }
    }
}
if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("Такой позиции в массиве нет");
}

