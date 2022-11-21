/*
16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

int[] num = new int[2];
string Result = "не является";

for (int i = 0; i < 2; i++)
{
    num[i] = new Random().Next(1, 1000);
}

if (num[0] / num[1] == num[1]) Result = Result.Replace("не ", "");

System.Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");
System.Console.WriteLine();
