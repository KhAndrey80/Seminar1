// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. a = 5; b = 7 ->  max = 7
/*System.Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(System.Console.ReadLine());

int max = first;

if (first > second )
{
    System.Console.WriteLine("Наибольшее число-> " + max);
}
else
{
   System.Console.WriteLine("Наибольшее число-> " + second);
}*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.2,3,7->7

System.Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int tretye = Convert.ToInt32(System.Console.ReadLine());

int max = first;
if (first > second )
{
    max = first;
}
else 
{
    max = second;
}

if (max > tretye)
{
   System.Console.WriteLine("Наибольшее число-> " + max);
}
else System.Console.WriteLine("Наибольшее число-> " + tretye);
