Console.Clear() ;
Console.Write ("Input number A : ") ;
double a = Convert.ToDouble(Console.ReadLine()) ;
Console.Write ("Input number B : ") ;
double b = Convert.ToDouble(Console.ReadLine()) ;

if( a == ( b * b ) )

    Console.WriteLine($"Number {a} is square of number {b}") ;
else
    Console.WriteLine($"Number {a} is  not square of number {b}") ;
