﻿Console.Write("Введите количество элементов массива: ");
int count_in_array = Convert.ToInt32(Console.ReadLine());
string[] array = new string[count_in_array];

for (int i = 0; i < count_in_array; i++)
{
    Console.Write($"Введите {i+1} элемент массива:");
    array[i] = Console.ReadLine();
}

Console.Write($"[ ");
for (int i = 0; i < count_in_array; i++)
{
    Console.Write($"{array[i]} ");
}

Console.Write($"] -> [ ");

for (int i = 0; i < count_in_array; i++)
{    
    if (array[i].Length < 4) Console.Write($"{array[i]} ");
}

Console.Write($"]");