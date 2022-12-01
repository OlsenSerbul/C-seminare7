// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N:  ");
int N = Convert.ToInt32(Console.ReadLine());

string Znacheniya(int N)
{
    string rezult = "";
    if(N == 1)
    {
        rezult = $"{rezult} 1 ";
        return rezult;
    }
    else
    {
        return $"{N} , {Znacheniya(N -1 )}";
    }
}
string result = Znacheniya(N);
Console.WriteLine(result);
