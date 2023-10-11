/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

string ShowAllEvenNumbers(int n)
{
    string res = $"{n} -> ";
    if (n > 1)
    {
        for (int e = 1; e <= n; e++)
        {
            if (e % 2 == 0)
            {
                if (e == 2)
                {
                    res += $"{e}";
                }
                else res += $", {e}";
            }
        }
    }
    else
    {
        res += "empty";
    }
    return res;
}
Console.WriteLine("Задача 8");
//Console.WriteLine(ShowAllEvenNumbers(1));
//Console.WriteLine(ShowAllEvenNumbers(2));
Console.WriteLine(ShowAllEvenNumbers(5));
Console.WriteLine(ShowAllEvenNumbers(8));
Console.WriteLine("\n");
