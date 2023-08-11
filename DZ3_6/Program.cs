// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num%2;

if(result==0)
{
    System.Console.WriteLine("число чётное и делиться на 2 ");

}
else

{
    System.Console.WriteLine($"Число не делиться на 2 не является чётным  ");
}
