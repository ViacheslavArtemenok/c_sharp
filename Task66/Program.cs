// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int GetRangeNaturalDigits(int min, int max)
{
    if (min == max) return min;
    return min + GetRangeNaturalDigits(min + 1, max);

}
void TestRangeNaturalDigits(int numberM, int numberN, int pattern)
{
    int sum = GetRangeNaturalDigits(numberM, numberN);
    bool res = sum == pattern;
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {pattern}");
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void PromptRangeNaturalDigits()
{
    Console.WriteLine("Введите целое натуральное число M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    if (numberM < 0)
    {
        Console.WriteLine("Ошибка: нужно ввести целое натуральное положительное число!!!");
        return;
    }
    Console.WriteLine("Введите целое натуральное число N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN < 0)
    {
        Console.WriteLine("Ошибка: нужно ввести целое натуральное положительное число!!!");
        return;
    }
    int sum = 0;
    if (numberN > numberM)
    {
        sum = GetRangeNaturalDigits(numberM, numberN);
    }
    if (numberN < numberM)
    {
        sum = GetRangeNaturalDigits(numberN, numberM);
    }
    Console.Write($"M = {numberM}; N = {numberN} -> {sum}");
}
TestRangeNaturalDigits(1, 15, 120);
TestRangeNaturalDigits(4, 8, 30);
PromptRangeNaturalDigits();

