// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNaturalDigits(int num)
{
    if (num <= 1)
    {
        Console.Write($"{num}");
    }
    else
    {
        Console.Write($"{num}, ");
        PrintNaturalDigits(num - 1);
    }
}

void PromptNaturalDigits()
{
    Console.WriteLine("Введите целое натуральное число больше нуля");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number <= 0)
    {
        Console.WriteLine("Ошибка: нужно ввести целое натуральное число больше нуля!!!"); //N = 1 -> "1", а N = 0 уже не выводится
    }
    else
    {
        Console.Write($"N = {number} -> \"");
        PrintNaturalDigits(number);
        Console.Write("\"");
    }
}

PromptNaturalDigits();


