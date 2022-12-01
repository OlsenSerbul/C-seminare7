//Напишите программу, которая на вход принимает два числа A и B.
// и возводит число А в степень В с помощью рекурсии.

Console.Write("Введите A:  ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите B:  ");
int B = Convert.ToInt32(Console.ReadLine());

int Power(int A, int B)
{
    if(B == 0)
    {
        return 1;
    }
    else
    {
        return A * Power(A, B - 1);
    }
}
Console.WriteLine(Power(A, B));