// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] GetRandomArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;

}
void ConvertArrayToString(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"{arr[i]}");
        }
        else Console.Write($", {arr[i]}");
    }
    Console.Write(" -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{arr[i]}");
        }
        else Console.Write($", {arr[i]}");
    }
    Console.Write("]");
}

void TestRandomArray(int length, int pattern)
{
    int[] randomArr = GetRandomArray(length);
    bool res = randomArr.Length == pattern;
    Console.WriteLine($"{length} -> {pattern}");
    Console.WriteLine($"{length} -> {randomArr.Length}");
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowRandomArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] res = GetRandomArray(length);
    ConvertArrayToString(res);
}

TestRandomArray(8, 8);
ShowRandomArray();