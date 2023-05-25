﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] FillArrayWithRandomNumber(int size)
{
 int [] arr = new int [size];
 Random rnd = new Random();
 for(int i = 0; i<arr.Length; i++)
 {
    arr[i] = rnd.Next(1, 11);
 }
 return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));

int sum = 0;

for (int i = 0; i<array.Length; i+=2)
{
        sum+=array[i];
}
System.Console.WriteLine(sum);