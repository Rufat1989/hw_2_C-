Console.Clear();
Console.Write("Введите день недели: ");
int d = int.Parse(Console.ReadLine()!);
if(d == 6 || d == 7)
{
    Console.Write($"{d}  -->  выходной");

}
else
{
    Console.Write($"{d}  -->  не выходной");
}