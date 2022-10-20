// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 7)

{
    if (num <= 5)
        Console.Write("Будни ");
    {
        if (num == 1)
            Console.Write("Понедельник");
        else if (num == 2)
            Console.Write("Вторник");
        else if (num == 3)
            Console.Write("Среда");
        else if (num == 4)
            Console.Write("Четверг");
        else if (num == 5)
            Console.Write("Пятница");
          
        else Console.Write("Выходной ");
        if (num == 6)
            Console.Write("Суббота");
        else if (num == 7)
            Console.Write("Воскресенье");
    }
}

else Console.WriteLine("Введенное число не входит в диапозон от 1 до 7. Попробуйте снова.");
