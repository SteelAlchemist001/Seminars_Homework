// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7



Console.Clear();
Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; Console.WriteLine(maxDigit);



// Console.Clear();
// int Number = new Random().Next(10, 100);
// int Max = 0;

// int MaxDigit()
// {
//     int DigitOne = Number / 10;
//     int DigitTwo = Number % 10;
//     if (DigitOne > DigitTwo) Max = DigitOne;
//     else Max = DigitTwo;

//     return Max;
// }

// MaxDigit();
// System.Console.WriteLine();
// System.Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");
// System.Console.WriteLine();

