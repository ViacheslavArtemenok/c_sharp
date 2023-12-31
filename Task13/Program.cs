﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int GetThirdDigit(int number)
{
    if (number < 0)
    {
        number *= -1;
    }
    if (number < 100)
    {
        return -1;
    }
    else
    {
        while (number > 999)
        {
            number /= 10;
        }
        return number %= 10;
    }
}

void TestThirdDigit(int number, int pattern)
{
    bool res = GetThirdDigit(number) == pattern;
    Console.WriteLine($"{number} -> {pattern}");
    Console.WriteLine($"{number} -> {GetThirdDigit(number)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowThirdDigit()
{
    Console.WriteLine("Введите трёхзначное или большее число");
    int number = Convert.ToInt32(Console.ReadLine());
    int res = GetThirdDigit(number);
    Console.WriteLine($"{number} -> {(res == -1 ? "третьей цифры нет" : res)}");
}

TestThirdDigit(645, 5);
TestThirdDigit(78, -1);
TestThirdDigit(32679, 6);
ShowThirdDigit();

