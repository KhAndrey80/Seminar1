// 1 - понедельник, 2 -вторник и т.д.
Console.WriteLine("Какой день недели вас интересует? Введите его номер.");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number== 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (number== 2)
{
   System.Console.WriteLine("Вторник"); 
}
else if (number== 3)
{
   System.Console.WriteLine("Среда"); 
}
else if (number== 4)
{
   System.Console.WriteLine("Четверг"); 
}
else if (number== 5)
{
   System.Console.WriteLine("Пятница"); 
}
else if (number== 6)
{
   System.Console.WriteLine("Суббота"); 
}
else if (number== 7)
{
   System.Console.WriteLine("Воскресенье"); 
}
else
{
   System.Console.WriteLine("Введите число от 1 до 7 :-)"); 
}