//Задача 8: Напишите программу, которая на вход 
//принимает число (N), а на выходе показывает все чётные 
//числа от 1 до N.

Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int index = 0;

if (N <= 1)

    Console.WriteLine("Таких чисел не существует");

else
{
    while (index < (N-1))
    {
        index += 2;
        Console.WriteLine(index);
    }
}