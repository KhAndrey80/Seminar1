// принимает 2 числа, проверяет, является ли первое кратным второму. Есл не кратно, выводить остаток от деления.
System.Console.WriteLine("Введите первое число");
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
}














//Принимает число и проверяет, кратно ли оно одновременно 7 и 23.