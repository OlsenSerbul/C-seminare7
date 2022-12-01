// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от М до N.

string FindPromejutokNM(int M, int N)
{
    string rezult = " ";
    if( M == N)
    {
        rezult += " ";
        return rezult;
    }
    else
    {
        return rezult + FindPromejutokMN(M, N + 1);
        
    }
}
string FindPromejutokMN(int M, int N)
{
    string rezult = "";
    if( N == M)
    {
        rezult += " ";
        return rezult;
    }
    else
    {
        return rezult + FindPromejutokMN(M + 1, N);
        
    }
}

Console.Write("Введите M:  ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N:  ");
int N = Convert.ToInt32(Console.ReadLine());
 if ( M > N );
 {
    Console.Write(FindPromejutokNM(M,N));
 }
 if (M == N)
 {
    Console.WriteLine("Промежутка нет");
 }
 if(M < N)
 {
   Console.Write(FindPromejutokMN(M,N));
 }

