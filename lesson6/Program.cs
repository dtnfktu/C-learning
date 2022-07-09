// Задача 1 (№41)

// Создание нового целочисленного массива заданой длины m вводом через консоль
int[] InputArray(int m)
{
    int[] massive = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
    }

    return massive;
}

// Вывод целочисленного массива в коносль, метод из прошлого урока lesson5
void ShowArray(int[] arr, string Separator = " ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(Separator);
    }
    Console.WriteLine();
}

// Подсчёт количества положительных элементов массива
int CountPositiveNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < 0) result++;

    return result;
}

// -------------------------------- Задача 1
Console.Clear();
Console.WriteLine("Задача 1");
Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());                // Задаём длину массива
int[] array = InputArray(M);                                // Вводим массив с клавиатуры

Console.WriteLine("\nИсходный массив:");
ShowArray(array, " ");
Console.WriteLine("Введено элементов больше нуля: " + CountPositiveNumbers(array));
Console.WriteLine();

// -------------------------------- Задача 2
Console.WriteLine("Задача 2");
