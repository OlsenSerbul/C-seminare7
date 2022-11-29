//  Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];
// С помощью переменной countNumber задаются числа внутри массива начиная с 1.
int  countNumber= 1;
//Заполняем периметр массива по часовой стрелке.
for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = countNumber;
    countNumber++;
}
   for (int i = 1; i < array.GetLength(0); i++)
{
    array[i, array.GetLength(1) - 1] = countNumber;
    countNumber++;
}
for (int j = array.GetLength(1) - 2; j >= 0; j--)
{
    array[array.GetLength(0)- 1, j] = countNumber;
    countNumber++;
}
for (int i = array.GetLength(0) - 2; i > 0; i--)
{
    array[i, 0] = countNumber;
    countNumber++;
}
//  задаём координаты ячейки, которую необходимо заполнить внутри.
int x = 1;
int y = 1;

while (countNumber < array.GetLength(0) * array.GetLength(1))
{//Движемся вправо.
    while (array[x, y + 1] == 0)
    {
        array[x, y] = countNumber;
        countNumber++;
        y++;
    }
//Движемся вниз.
    while (array[x + 1, y] == 0)
    {
        array[x, y] = countNumber;
        countNumber++;
        x++;
    }
//Движемся влево.
    while (array[x, y - 1] == 0)
    {
        array[x, y] = countNumber;
        countNumber++;
        y--;
    }
//При данном решении в центре всегда остаётся незаполненная ячейка
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (array[i, j] == 0) 
            {
                array[i, j] = countNumber;
            }
        }
    }
}
// выводим на печать
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}