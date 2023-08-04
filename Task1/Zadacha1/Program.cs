//принять 2 числа и проверить, является ли первое число квадратом второго. a=25 b=5 да
System.Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(System.Console.ReadLine());

if (first == second * second)
{
    System.Console.WriteLine("Да, является квадратом");
}
else
{
   System.Console.WriteLine("Нет, не является"); 
}
