﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число соответствующее дню недели от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0 & a <= 5)
{
Console.WriteLine("Будний день");
}
else if (a == 6 || a == 7)
{
Console.WriteLine("Выходной");
}