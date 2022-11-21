Console.Clear () ;
Console.Write("Input number N : ") ;
int N = int.Parse(Console.ReadLine()) ;
int antiN = N*-1 ;
while (antiN <= N)
{
    Console.WriteLine(antiN) ;
     antiN++ ;
}
while (N <= antiN)
{
    Console.WriteLine(antiN) ;
     antiN-- ;
}
