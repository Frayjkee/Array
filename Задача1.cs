using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 случайных целых чисел от 1 до 100
        int[] numbers = GenerateRandomNumbers(10, 1, 101);

        // Выводим сгенерированный массив на экран
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        // Находим количество элементов массива, значения которых лежат в отрезке [20, 90]
        int count = CountInRange(numbers, 20, 90);

        // Выводим результат
        Console.WriteLine($"Количество элементов в диапазоне [20, 90]: {count}");

        // Ждем нажатия клавиши перед закрытием консоли
        Console.ReadLine();
    }

    // Функция для генерации массива случайных чисел в заданном диапазоне
    static int[] GenerateRandomNumbers(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    // Функция для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }

    // Функция для подсчета количества элементов массива в заданном диапазоне
    static int CountInRange(int[] array, int min, int max)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number >= min && number <= max)
            {
                count++;
            }
        }

        return count;
    }
}
