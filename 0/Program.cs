Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
if(Math.Pow(numberB,2) == numberA)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}