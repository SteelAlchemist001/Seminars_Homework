// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4


Console.Clear();
int[] array = new int[10];
Random rand = new Random();
int count = 0;
for (int i = 0; i < 10; i++)
{
    array[i] = rand.Next(1, 10);
    if ((array[i] % 2) == 0) count++;
    Console.Write($" {i}");
}

Console.WriteLine();
Console.WriteLine($"Чётных чисел = {count}");

