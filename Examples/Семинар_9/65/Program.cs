// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите начало промежутка М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец промежутка N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int M, int N)
{
if (M == 0)
{
    return ( N * (N + 1))/ 2;
}
else 
    if (N == 0)
    {
        return (M *( M + 1))/ 2;
    }
    if (M == N)
    {
        return M;
    }
    if (M < N)
    {
        return N + SumNumbers(M, N -1);
    }
    else return N + SumNumbers(M, N + 1);
}
Console.WriteLine($"Сумма = {SumNumbers(M, N)}");
