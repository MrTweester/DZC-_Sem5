// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1


// int [] FillArrayWithRandomNumber(int size)
// {
//  int [] arr = new int [size];
//  Random rnd = new Random();
//  for(int i = 0; i<arr.Length; i++)
//  {
//     arr[i] = rnd.NextDouble(-100, 100);
//  }
//  return arr;
// }

// System.Console.Write("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int [] array = FillArrayWithRandomNumber(length);
// System.Console.WriteLine(string.Join(", ", array));

// double itemMin=array[0];
// double itemMax=array[0];
// double raz=0;

// for (int i=0; i<array.Length; i++)
// {
//     if(itemMax<array[i])
//     {
//         itemMax=array[i];
//     }
//     if(itemMin>array[i])
//     {
//         itemMin=array[i];
//     }
// }

// raz = itemMax-itemMin;
// System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива равно: {Math.Round(raz,2)}");

Console.WriteLine("Classic Math.Round in CSharp");
Console.WriteLine(Math.Round(4.4)); // 4
Console.WriteLine(Math.Round(4.5)); // 4
Console.WriteLine(Math.Round(4.6)); // 5
Console.WriteLine(Math.Round(5.5)); // 6



