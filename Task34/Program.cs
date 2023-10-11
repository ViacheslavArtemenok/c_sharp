// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве
// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
// Аргументы, передаваемые в метод/функцию:
// '124, 378, 593, 821, 456'
// На выходе:
// Массив:
// 124 378 593 821 456 
// Количество четных элементов: 3
using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    {
        int countEvenElements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                countEvenElements++;
            }
        }
        return countEvenElements;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine($"{array[i]}");
            }
            else Console.Write($"{array[i]} ");
        }

    }


    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}
