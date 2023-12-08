// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28


// Не могу понять в чём проблема

int min = 1;
int max = 99;

static void main(string[] args)
{
    System.Console.Write("Введите размерность генерируемого массива: ");

    int arraySize = GetArraySizeFromConsole();
    while (arraySize < 0.0)
    {
        arraySize = GetArraySizeFromConsole();
    }

    double[] array = GetArrayWithRandomValue(arraySize);

    System.Console.WriteLine("Оригинальный массив:");
    System.Console.WriteLine(PrintArray(array));

    System.Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива:");
    System.Console.WriteLine(getDifferenceMaxMinValue(array).ToString("N2"));
}

static int GetArraySizeFromConsole()
{
    try
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
    }
    return -1;
}

static double[] GetArrayWithRandomValue(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = (new Random().NextDouble()) + (new Random().Next(min, max));
    }
    return array;
}

static double getDifferenceMaxMinValue(double[] array)
{
    double minVal = 0.0;
    double maxVal = 0.0;
    foreach (double item in array)
    {
        if (item < minVal) minVal = item;
        if (item > maxVal) maxVal = item;
    }
    return maxVal - minVal;
}

static string PrintArray(double[] array)
{
    string result = "";
    foreach (double item in array)
    {
        result = result + item + " ";
    }
    return result;
}

