Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if(n / 100 == 0)
{
    Console.Write ($"{n}, третьего числа нет");

}

else
{
    while (n > 999)
{
    n = n / 10;
    
}
Console.Write ($"{n}, третье число {n % 10}");
}





