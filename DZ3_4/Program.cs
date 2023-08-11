// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

System.Console.WriteLine("Напишите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Напишите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Напишите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = ");
Console.WriteLine(max);