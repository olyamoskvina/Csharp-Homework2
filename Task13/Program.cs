// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string? number = Console.ReadLine();

if (int.TryParse(number, out int num)) 
{
    string num1 = Convert.ToString(Math.Abs(num));
    if (Math.Abs(num) > 99)
    {
        Console.Write($"Третья цифра введенного числа: {num1[2]}");
    }
    else Console.Write("третьей цифры нет");

}
else Console.Write("Вы ввели НЕ число. Попробуйте снова");

