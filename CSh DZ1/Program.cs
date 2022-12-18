//Задача 1
/*Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2){
  Console.Write($"Max = {num1}");
}
else {
  Console.Write($"Max = {num2}");
}*/
//Задача 2
/*Console.WriteLine("Введите число 1: ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int numb2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3: ");
int numb3 = int.Parse(Console.ReadLine()!);
int max = numb1;

if (numb2 > max) max = numb2; 
if (numb3 > max) max = numb3; 
Console.Write($"Max = {max}");*/
//Задача 3
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2! == 0){
    Console.Write($"Число являеться чётным");
}
else {
  Console.Write($"Число являеться не чётным");
}
