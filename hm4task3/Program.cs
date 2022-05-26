//29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 10);
    }
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }

    }
    Console.Write("]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);