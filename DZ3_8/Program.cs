﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на 
// выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num%2;
int A = 0;
   while (A<=num)
     
     {
        Console.Write($"{A} ");
        A=A+2;
     }