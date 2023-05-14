using System;
public class BubbleSortExample
{
    public static void Main()
    {
        // Тестовый случай 1: Проверка сортировки для уже отсортированного массива
        int[] array1 = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Исходный массив 1:");
        PrintArray(array1);
        BubbleSort(array1);
        Console.WriteLine("Отсортированный массив 1:");
        PrintArray(array1);
        Console.WriteLine();

        // Тестовый случай 2: Проверка сортировки для массива, отсортированного в обратном порядке
        int[] array2 = { 5, 4, 3, 2, 1 };
        Console.WriteLine("Исходный массив 2:");
        PrintArray(array2);
        BubbleSort(array2);
        Console.WriteLine("Отсортированный массив 2:");
        PrintArray(array2);
        Console.WriteLine();

        // Тестовый случай 3: Проверка сортировки для случайно сгенерированного массива
        int[] array3 = GenerateRandomArray(10, 1, 100);
        Console.WriteLine("Исходный массив 3:");
        PrintArray(array3);
        BubbleSort(array3);
        Console.WriteLine("Отсортированный массив 3:");
        PrintArray(array3);
        Console.WriteLine();

        // Тестовый случай 4: Проверка сортировки для массива с одинаковыми элементами
        int[] array4 = { 5, 5, 5, 5, 5 };
        Console.WriteLine("Исходный массив 4:");
        PrintArray(array4);
        BubbleSort(array4);
        Console.WriteLine("Отсортированный массив 4:");
        PrintArray(array4);
        Console.WriteLine();

        // Тестовый случай 5: Проверка сортировки для пустого массива
        int[] array5 = new int[0];
        Console.WriteLine("Исходный массив 5:");
        PrintArray(array5);
        BubbleSort(array5);
        Console.WriteLine("Отсортированный массив 5:");
        PrintArray(array5);
        Console.WriteLine();

    int[] array = GenerateRandomArray(10, 1, 100); // Генерация массива из 10 случайных чисел от 1 до 100 
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        BubbleSort(array); // Сортировка массива методом пузырька Console.WriteLine("Отсортированный массив:"); 
        PrintArray(array);
    }


    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j]; arr[j] = arr[j + 1]; arr[j + 1] = temp;
                }
            }
        }
    }

    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
