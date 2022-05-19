//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 99 & numberA < 1000)
{
int numberOne = numberA / 100;
int numberTwo = (numberA - numberOne * 100) / 10;
int numberThree = numberA - numberOne * 100 - numberTwo * 10;
Console.WriteLine(numberTwo);
}
else
{
System.Console.WriteLine("Вы ввели не верное число");
}