/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
int GetGreaterNumber(int a, int b)
{
    if (a == b)
    {
        Console.Write("Числа равны! ");
        return 0;
    }
    else if (a > b)
    {
        return a;
    }
    else return b;
}
Console.WriteLine("Задача 2");
Console.WriteLine($"a = 3; b = 3 -> max = {GetGreaterNumber(3, 3)}");
Console.WriteLine($"a = 5; b = 7 -> max = {GetGreaterNumber(5, 7)}");
Console.WriteLine($"a = 2; b = 10 -> max = {GetGreaterNumber(2, 10)}");
Console.WriteLine($"a = -9; b = -3 -> max = {GetGreaterNumber(-9, -3)}");
Console.WriteLine("\n");
