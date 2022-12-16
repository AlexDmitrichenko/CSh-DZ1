//Однострочный коментарий

/*Многострочный
коментарий или не активный код*/

// Задача Программа принимает на вход число и возводит его в квадрат (sqr)
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Число {number} в квадрате равно {sqr}");
