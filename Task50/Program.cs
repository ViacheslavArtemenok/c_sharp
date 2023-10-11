// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
// Пример
// n = 3;
// m = 4;
// k = 2;
// x = 8;
// y = 3;
// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
/*
1   3   5   7   
9   11  13  15  
17  19  21  23  
There is no such index
*/

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (j == 0)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else matrix[i, j] = matrix[i - 1, m - 1] + k;
                }
                else matrix[i, j] = matrix[i, j - 1] + k;
            }
        }
        return matrix;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        int[] results = new int[] { 0, 1 };
        if (rowPosition - 1 > 0 && columnPosition - 1 > 0)
        {
            if (rowPosition - 1 < matrix.GetLength(0) && columnPosition - 1 < matrix.GetLength(1))
            {
                results[0] = matrix[rowPosition - 1, columnPosition - 1];
                results[1] = 0;
            }
        }
        return results;
    }

    public static void PrintCheckIfError(int[] results, int x, int y)
    {
        if (results[1] == 1)
        {
            Console.WriteLine("There is no such index");
        }
        else Console.WriteLine($"The number in [{x}, {y}] is {results[0]}");
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
            x = 2;
            y = 4;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}