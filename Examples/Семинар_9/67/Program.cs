// Напишите программу, которая будет принимать на вход число и возвращать егое сумму цифр

Console.Write("Введите M:  ");
int M = Convert.ToInt32(Console.ReadLine());

int FindSum(int M)
{
    
    if (M  < 10 )
    {
        return M;
        
    }
    else
    {
        
        return M % 10 + FindSum(M / 10 );
    }
}
Console.WriteLine(FindSum(M));