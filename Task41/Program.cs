// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
int[] GetArrayOfDigits(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите число!");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
    return arr;

}

int GetPosDigitsInArray(int[] arr)
{
    int countPosDigits = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            countPosDigits++;
        }
    }
    return countPosDigits;
}

void ConvertArrayToString(int[] arr, int res)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"{arr[i]}");
        }
        else Console.Write($", {arr[i]}");
    }
    Console.Write($" -> {res}");
    Console.WriteLine();
}

void TestPosDigitsInArray(int[] arr, int pattern)
{
    int countPos = GetPosDigitsInArray(arr);
    bool res = countPos == pattern;
    ConvertArrayToString(arr, pattern);
    ConvertArrayToString(arr, countPos);
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowPosDigitsInArray()
{
    Console.WriteLine("Введите желаемое количество чисел");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 0)
    {
        Console.WriteLine("Вы ввели ошибочное значение!");
        return;
    }
    int[] arr = GetArrayOfDigits(length);
    int res = GetPosDigitsInArray(arr);
    ConvertArrayToString(arr, res);
}

TestPosDigitsInArray(new int[] { 0, 7, 8, -2, -2 }, 2);
TestPosDigitsInArray(new int[] { 1, -7, 567, 89, 223 }, 4);
ShowPosDigitsInArray();