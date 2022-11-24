/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int result = number;
int count2 = 0;
for (result = number; result > 0; count2++) result = result /10;

Console.WriteLine($"В числе {number} {count2} цифр");