//Написать программу, выдающую квадрат введенного числа
Console.WriteLine("Введите число");
string input = Console.ReadLine(); // int imput = Convert.ToInt32(Console.ReadLine())
int number = Convert.ToInt32(input);
int result = number * number;
Console.WriteLine("Наш результат: " + result);
