// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int a = InputNumbers("Количество элементов массива по вертикали: ");
int b = InputNumbers("Количество элементов массива по горизонтали: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[a, b];
CreateArray(array);
PrintArray(array);

int minSumLine = 0;
int sumLine = LineSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
int tempSumLine = LineSum(array, i);
if (sumLine > tempSumLine)
{
sumLine = tempSumLine;
minSumLine = i;
}
}

Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой {sumLine} элементов ");


int LineSum(int[,] array, int i)
{
int sumLine = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sumLine += array[i,j];
}
return sumLine;
}

int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

void CreateArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(range);
}
}
}

void PrintArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}
}
