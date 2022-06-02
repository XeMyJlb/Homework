// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество цифр: ");
int userNumbers = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[userNumbers];

void InputNumbers(int userNumbers)
{
for (int i = 0; i < userNumbers; i++)
{
Console.WriteLine($"Введи {i + 1} число: ");
massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
}
}
int Compare(int[] massiveNumbers)
{
int count = 0;
for (int i = 0; i < massiveNumbers.Length; i++)
{
if (massiveNumbers[i] > 0) count += 1;
}
return count;
}

InputNumbers(userNumbers);

Console.WriteLine($"Больше нуля: {Compare(massiveNumbers)} ");
