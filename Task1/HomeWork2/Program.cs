/* 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine((number %100-((number %100) %10) )/ 10);*/


/*2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (number > 100 && number <1000)
{
    System.Console.WriteLine(number 10%);
}
else 
{
    System.Console.WriteLine("Хрен знает");
}



/*3.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
/*System.Console.WriteLine("Введите число для определения дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number > 7)
{
    System.Console.WriteLine("Введите корректное число");
}
else if (number == 6 || number == 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("Рабочий день");
}*/

