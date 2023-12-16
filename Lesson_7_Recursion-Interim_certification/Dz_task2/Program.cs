// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
int numberM = ReadUserNumber("Введите число M: ");
int numberN = ReadUserNumber("Введите число N: ");
Console.WriteLine(Ackerman(numberM, numberN));

int ReadUserNumber(string userText)
{
    Console.Write(userText);
    int numberUser = Convert.ToInt32(Console.ReadLine());
    return numberUser;
}

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}
