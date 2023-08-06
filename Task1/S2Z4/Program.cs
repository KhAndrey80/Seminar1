//Вывести случайное число из 10 до 99 и показать наибольшую цифру числа.
Random rand = new Random();
int number = rand.Next(10, 100); //генерирует случайные числа [ - входит число в диапазон, ( - не входит
//int a = new Random().Next(10, 100) - альтернативный вариант записи

int a = number / 10;
int b = number % 10; 

System.Console.WriteLine(number);
if (a > b)
{
    System.Console.WriteLine("Максимальная цифра числa = " + a);
}
else if(b > a)
{
System.Console.WriteLine("Максимальная цифра числa = " + b);
}
else {
System.Console.WriteLine($"Все цифры равны {a} = {b}");
}