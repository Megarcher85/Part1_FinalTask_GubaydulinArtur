﻿Console.WriteLine("Введите размер текстового массива:");
int size = int.Parse(Console.ReadLine()!);
String[] arr1 = new String[size];

Console.WriteLine($"Введите {size} элементов текстового массива:");
for (int i = 0; i < size; i++)
{
    arr1[i] = Console.ReadLine();
}

int size2 = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        size2 += 1;
    };
}

String[] arr2 = new String[size2];

int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        arr2[j] = arr1[i];
        j++;
    };
}

for (int i = 0; i < arr2.Length; i++)
{
    Console.Write($"{arr2[i]} ");
}