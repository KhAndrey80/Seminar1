// Программа принимает число N, выводит числа от -N до N
// Вторая задача: принимает на вход трехзначное число и на выходе показывает последнюю цифру
/*Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(System.Console.ReadLine());
int number2 = - number1;
while (number2 <= number1)
{
System.Console.Write(number2 +" ");
    number2++;
}*/
 Console.WriteLine("Введите трехзначное число");
 int number = Convert.ToInt32(System.Console.ReadLine());
 int result = number % 10;
 System.Console.WriteLine(result);

