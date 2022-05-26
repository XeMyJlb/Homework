//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiate(int numberA, int numberB)
{
int result = 1;
for (int i = 1; i <= numberB; i++)
{
result = result * numberA;
}
return result;
}
System.Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiate = Exponentiate(numberA, numberB);

System.Console.WriteLine(exponentiate);