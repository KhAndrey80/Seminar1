//Выводит случайное трехзначное число удаляет вторую цифру

/*Random rand = new Random();
int number = rand.Next(100, 1000);

System.Console.WriteLine(number);
int a = number / 100;
int b = number % 10; 
int c = a*10 +b;
System.Console.WriteLine(c);*/

//Программа, принимает 2 числа и проверяет, являются ли одно из них квадратом другого.

System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1 * number1) // || - или && - и 
{
    System.Console.WriteLine("Верно");
}
else 
{
    System.Console.WriteLine("Не верно");
}

