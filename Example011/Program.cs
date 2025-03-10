﻿// Описание метода заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
}

// Описание метода печати массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Определение массива из 10-ти элементов

FillArray(array); //Вызов метода заполнения массива
array[4]=4;
array[6]=4;
PrintArray(array); //Распечатывание массива
Console.WriteLine();

int pos = Indexof(array, 4);
//
Console.WriteLine(pos);