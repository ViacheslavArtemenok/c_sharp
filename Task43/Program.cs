// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4, -> (-0,5; -0,5)
int[] GetArrayOfParams(string[] arrNames, int length)
{
    int[] arrOfParams = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {arrNames[i]}");
        arrOfParams[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrOfParams;

}

double[] GetCrossOfLines(int[] arr)
{
    if (arr[0] != arr[2])
    {
        double x = Convert.ToDouble((arr[3] - arr[1])) / Convert.ToDouble((arr[0] - arr[2])); //{"k1", "b1", "k2", "b2"}
        if (arr[1] == arr[3] && arr[2] > arr[0])
        {
            x *= -1;
        }
        double y = arr[0] * x + arr[1];

        return new double[] { x, y };
    }
    else return new double[] { 0, 0 };
}

void ConvertArrayToString(int[] arr, string[] arrNames, double[] cross)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"{arrNames[i]} = {arr[i]}");
        }
        else Console.Write($", {arrNames[i]} = {arr[i]}");
    }
    if (arr[0] == arr[2])
    {
        if (arr[1] == arr[3])
        {
            Console.Write($" -> Прямые совпадают!");
        }
        else Console.Write($" -> Прямые параллельны!");
    }
    else
    {
        Console.Write($" -> ({cross[0]}; {cross[1]})");
    }
    Console.WriteLine();
}

void TestCrossOfLines(int[] arr, double[] pattern)
{
    string[] arrNames = new string[] { "k1", "b1", "k2", "b2" };
    double[] cross = GetCrossOfLines(arr);
    bool res = cross[0] == pattern[0];
    res = cross[1] == pattern[1];
    ConvertArrayToString(arr, arrNames, pattern);
    ConvertArrayToString(arr, arrNames, cross);
    Console.WriteLine($"{(res ? "Тест пройден!" : "Тест не пройден")}");
}

void ShowCrossOfLines()
{
    Console.WriteLine("Даны уравнения (y = k1 * x + b1) и (y = k2 * x + b2);");
    string[] arrNames = new string[] { "k1", "b1", "k2", "b2" };
    int[] arrOfParams = GetArrayOfParams(arrNames, 4);
    double[] cross = GetCrossOfLines(arrOfParams);
    ConvertArrayToString(arrOfParams, arrNames, cross);
}

TestCrossOfLines(new int[] { 5, 2, 9, 4 }, new double[] { -0.5, -0.5 });
TestCrossOfLines(new int[] { 5, 2, 5, 4 }, new double[] { 0, 0 });
TestCrossOfLines(new int[] { 5, 5, 5, 5 }, new double[] { 0, 0 });
ShowCrossOfLines();
