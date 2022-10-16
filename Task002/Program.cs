//Задача 2: Напишите программу, которая
//1. на вход принимает два числа
//2. и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Ведите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a == b) Console.Write("a = b"); 
if (a < b) Console.Write("max = "+ b);
if (a > b) Console.Write("max = "+ a);
