
/*
Задача: Напишите программу, которая принимает на вход время приезда на День рождения в субботу 26.11.2022
и проверяет, является ли это время правильным при условии, что:
- до 12.00 именинник занят;
- пригласительное время - 14.00.
14.00 -> да (true)
12.01 -> нет (false)
*/

Console.Write("Введите время приезда на День рождения в субботу 26.11.2022: ");
// double timeUser2 = Convert.ToInt32(timeUser);
// double timeNumber = 14.00;
string timeUser = Console.ReadLine();
string timeNumber = "14.00";

if (timeUser == timeNumber)
{
    Console.WriteLine($"Указанное Вами время {timeUser} верное");
}
else Console.WriteLine($"Указанное Вами время {timeUser} не верное");