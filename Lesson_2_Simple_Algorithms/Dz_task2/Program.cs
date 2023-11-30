// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
//  2,  3 => 1
// -5,  3 => 2
// -3, -2 => 3
//  4, -2 => 4


// Console.Clear();
// Console.Write("Введите координаты точки X и Y через пробел:"); string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x > 0 && y > 0)
//     Console.WriteLine($"в {1}-й четверти");
// else if (x < 0 && y > 0)
//     Console.WriteLine($"в {2}-й четверти");
// else if (x < 0 && y < 0)
//     Console.WriteLine($"в {3}-й четверти");
// else if (x > 0 && y < 0)
//     Console.WriteLine($"в {4}-й четверти");
// else
//     Console.WriteLine($"Точка находится на оси координат");


Console.Clear();
Console.WriteLine();

int QuarterNumber = 0;
int x = new Random().Next(-100, 100);
int y = new Random().Next(-100, 100);
Console.WriteLine($"Координаты точки: ({x}, {y})");

if (x * y == 0) QuarterNumber = 0;
else if (x > 0 && y > 0) QuarterNumber = 1;
else if (x < 0 && y > 0) QuarterNumber = 2;
else if (x < 0 && y < 0) QuarterNumber = 3;
else if (x > 0 && y < 0) QuarterNumber = 4;// else QuarterNumber = 4;


Console.Write($"Точка с координатами ({x}, {y}) находится ");
if (QuarterNumber == 0) Console.WriteLine("на одной из оси координат");
else Console.WriteLine($"в {QuarterNumber}-й четверти");
Console.WriteLine();
