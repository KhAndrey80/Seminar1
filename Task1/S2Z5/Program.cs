//Выводит случайное трехзначное число удаляет вторую цифру

Random rand = new Random();
int number = rand.Next(100, 1000);

System.Console.WriteLine(number);
int a = number / 100;
int b = number % 10; 
int c = a*10 +b;
System.Console.WriteLine(c);

