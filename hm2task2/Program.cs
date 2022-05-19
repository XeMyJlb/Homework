// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
System.Console.WriteLine("Третьего чилса нет");
}
else
{
Console.WriteLine(number > 99 ? number.ToString()[2]:'-');
}
//P.S Не знал как решить данную задачу и загуглировал. 
