// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 3432 -> да.

Console.Clear();
Console.Write("введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int numA = 0;
int numB = num;
int result = 0;

while ( numB > 0)
{
numA = numB % 10;
result = result * 10 + numberA;
numB = numB / 10;
}
if ( num == result) Console.WriteLine($"введенное число: {num} => является палиндромом.");
else
{
Console.Write($"введенное число: {num} => НЕ является палиндромом.");
}