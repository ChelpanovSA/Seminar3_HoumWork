// *Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да*



Console.Clear();
Console.Write("введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int numA = num / 10000;
int numB = num / 1000 % 10;
int numC = num / 10 % 10;
int numD = num % 10;

if (numA == numD && numB == numC)
{
 Console.WriteLine($"введенное число: {num} => является палиндромом.");
}
else Console.Write($"введенное число: {num} => НЕ является палиндромом.");

