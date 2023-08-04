// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. a = 5; b = 7 ->  max = 7
System.Console.WriteLine("Введите первое число");
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
}
