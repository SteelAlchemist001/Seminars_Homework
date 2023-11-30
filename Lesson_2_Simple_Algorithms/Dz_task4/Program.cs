// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//  568 => 5,6,8
//    8 => 8
// 9542 => 9,5,4,2


Console.Clear();
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ", ");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
} 
// Не понял как в первом  решение сделать вывод ответа как во в тором решение задания



// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int first = number;
// string result = string.Empty;
// for (; number > 0; number /= 10)
// {
//     if (number == first) result = number % 10 + " " + result;
//     else result = number % 10 + ", " + result;
// }

// Console.Write(result);
