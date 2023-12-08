// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2 ( 21, 23)

int size = 100; 
int min = 1;
int max = 100;

int[] FillArray(int size, int min, int max)
{
    Console.Clear();
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 0;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (arr[i] >= 20 && arr[i] <= 90) count++;
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Количество чисел из диапазона [20, 90] равно {count}");
    Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));

