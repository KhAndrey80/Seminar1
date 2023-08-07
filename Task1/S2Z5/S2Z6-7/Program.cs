// принимает 2 числа, проверяет, является ли первое кратным второму. Есл не кратно, выводить остаток от деления.
/*System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int ost = number1 % number2;

if (ost == 0) // || - или && - и 
{
    System.Console.WriteLine("Кратно");
}
else 
{
    System.Console.WriteLine("Не кратно. Остаток: " + ost);
}*/

//Принимает число и проверяет, кратно ли оно одновременно 7 и 23.
System.Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 %7 == 0 && number1 %23 == 0 ) // || - или && - и !- не
{
    System.Console.WriteLine("Кратно 7 и 23");
}
else 
{
    System.Console.WriteLine("Не кратно");
}
