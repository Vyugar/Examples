/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Write("Введите число: ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int GetFactorial(int N)
{
    int F = 1;
    for (int num = 1; num <=N; num++)
    {
        F = F * num;
    }
    return F;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetFactorial(N)}");
Console.WriteLine();