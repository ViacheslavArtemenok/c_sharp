/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22*/
int GetMaxNumber(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}
Console.WriteLine("Задача 4");
Console.WriteLine($"2, 3, 7 -> {GetMaxNumber(2, 3, 7)}");
Console.WriteLine($"44, 5, 78 -> {GetMaxNumber(44, 5, 78)}");
Console.WriteLine($"22, 3, 9 -> {GetMaxNumber(22, 3, 9)}");
Console.WriteLine("\n");