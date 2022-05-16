//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a1 = 2;
int b1 = 3;
int c1 = 7;
int a2 = 44;
int b2 = 5;
int c2 = 78;
int a3 = 22;
int b3 = 3;
int c3 = 9;

int max1 = a1;
if (b1 > max1) max1 = b1;
if (c1 > max1) max1 = c1;
Console.WriteLine(max1);

int max2 = a2;
if (b2 > max2) max2 = b2;
if (c2 > max2) max2 = c2;
Console.WriteLine(max2);

int max3 = a3;
if (b3 > max3) max3 = b3;
if (c3 > max3) max3 = c3;
Console.WriteLine(max3);
