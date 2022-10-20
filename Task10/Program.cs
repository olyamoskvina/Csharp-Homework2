// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехначное число: ");
string ? number = Console.ReadLine();

if(int.TryParse(number, out int num))
{
    string num1 = Convert.ToString(Math.Abs(num));
    if(Math.Abs(num) > 99 && Math.Abs(num)<1000)
    {
        Console.WriteLine($"Вторая цифра введенного числа: {num1[1]}");
    }
    else 
    {
        Console.WriteLine("введенное число не трехзначное");
    }
}    
else 
{
    Console.Write("Вы ввели НЕ число");
}