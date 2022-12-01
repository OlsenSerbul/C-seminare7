// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от М до N.

string NumberRec(int M, int N);
{
    if(M <= N)
    {
        return NumberRec(M, N -1) + $"{N}";
    }
    else return String.Empty;
}

Console.Write("Введите M:  ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N:  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberRec(M, N));

