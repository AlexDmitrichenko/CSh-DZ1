//Однострочный коментарий

/*Многострочный
коментарий или не активный код*/

// Задача 1 Программа принимает на вход число и возводит его в квадрат (sqr)
/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Число {number} в квадрате равно {sqr}");*/
// Задача 2 Программа принимает на вход одно число (N),
//а на выходе показывает все целые числа в промежутке от (-N до N)
/*Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine()!);

int numb1 = -numb;

while (numb1 <= numb){
   Console.Write($"{numb1}, ");
   numb1++;
}*/
// Задача 3 Программа на вход принимает 2 числа 
//и проверяет является ли 1 число квадратом 2
/*Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);
int sqr = Convert.ToInt32(Math.Pow(num1, 2));

if (sqr == num2){
  Console.Write($"1 число являеться квадратом 2");
}
else {
  Console.Write($"1 число не являеться квадратом 2");
}*/
// Задача 4 Программа выдает название дня недели по заданному номеру
/*Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day == 1)
   Console.WriteLine("Понедельник"); 
if (day == 2)
   Console.WriteLine("Вторник"); 
if (day == 3)
   Console.WriteLine("Среда"); 
if (day == 4)
   Console.WriteLine("Четверг"); 
if (day == 5)
   Console.WriteLine("Пятница"); 
if (day == 6)
   Console.WriteLine("Суббота"); 
if (day == 7)
   Console.WriteLine("Воскресенье");*/
   
// Задача 5 Программа принимает на вход 3-х значное число и 
//на выходе показывает его последнею цифру
/*onsole.WriteLine("Введите трёхзначное число: ");
int numb3 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последняя цифра равна {Convert.ToInt32(numb3%10)}");*/
