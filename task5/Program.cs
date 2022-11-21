Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int last = number%10;
Console.WriteLine(last);