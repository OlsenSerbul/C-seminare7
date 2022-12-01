// задайте значение N, напишите программу, которая
// выведет все значения от N до 1.
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