// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetSumOfDigits(int number)
{
    int res = 0;
    if (number < 0)
    {
        number *= -1;
    }
    while (number > 0)
    {
        res += number % 10;
        number /= 10;
    }
    return res;

}

void TestSumOfDigits(int number, int pattern)
{
    bool res = GetSumOfDigits(number) == pattern;
    Console.WriteLine($"{number} -> {pattern}");
    Console.WriteLine($"{number} -> {GetSumOfDigits(number)}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowSumOfDigits()
{
    Console.WriteLine("Введите целое число");
    int number = Convert.ToInt32(Console.ReadLine());
    int res = GetSumOfDigits(number);
    Console.WriteLine($"{number} -> {res}");
}

TestSumOfDigits(452, 11);
TestSumOfDigits(82, 10);
TestSumOfDigits(9012, 12);
ShowSumOfDigits();