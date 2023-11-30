// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// a = 50 => нет
// a = 7 => нет
// a = 322 => да


// Console.Clear();
// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


Console.Clear();
int GetUserInput(string str)
{
    Console.WriteLine(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

bool DivisionTo(int a, int a1, int a2)
{
    return a % a1 == 0 && a % a2 == 0;
}

int number = GetUserInput($"Введите число: ");
bool div7a23 = DivisionTo(number, 7, 23);
Console.WriteLine(div7a23 ? "да" : "нет"); //тернарный оператор
