//Задача 4: Напишите программу, которая:
//1. принимает на вход три числа;
//2. выдаёт максимальное из этих чисел.



Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(max < b) max = b;
if(max < c) max = c;

Console.Write(max);