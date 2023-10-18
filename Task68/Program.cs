// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int GetResultOfAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return GetResultOfAkkerman(m - 1, 1);
    return GetResultOfAkkerman(m - 1, GetResultOfAkkerman(m, n - 1));
}

void TestResultOfAkkerman(int numberM, int numberN, int pattern)
{
    int resOfAkkerman = GetResultOfAkkerman(numberM, numberN);
    bool resTest = resOfAkkerman == pattern;
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {pattern}");
    Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {resOfAkkerman}");
    Console.WriteLine($"{(resTest ? "Тест пройден!" : "Тест не пройден")}");
}

void PromptResultOfAkkerman()
{
    Console.WriteLine("Введите целое натуральное неотрицательное число m");
    int numberM = Convert.ToInt32(Console.ReadLine());
    if (numberM < 0)
    {
        Console.WriteLine("Ошибка: нужно ввести целое натуральное неотрицательное число!!!");
        return;
    }
    Console.WriteLine("Введите целое натуральное неотрицательное число n");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN < 0)
    {
        Console.WriteLine("Ошибка: нужно ввести целое натуральное неотрицательное число!!!");
        return;
    }
    int resOfAkkerman = GetResultOfAkkerman(numberM, numberN);
    Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) = {resOfAkkerman}");
}
TestResultOfAkkerman(2, 3, 9);
TestResultOfAkkerman(3, 2, 29);
TestResultOfAkkerman(3, 11, 16381);
PromptResultOfAkkerman();
