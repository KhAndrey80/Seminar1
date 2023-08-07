System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (number > 100 && number <1000)
{
    System.Console.WriteLine(number %10);
}
else 
{
    System.Console.WriteLine("Хрен знает");
}
