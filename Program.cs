﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое число больше 1:");
int number = int.Parse(Console.ReadLine());

void Numbers (int number)
{
    if (number < 0) 
    Console.Write("тупой? написанно же БОЛЬШЕ 1"); 
    return ;
    if (number == 0) return;
    Console.Write("{0,4}", number);
    Numbers (number - 1);
}

Numbers(number);





