// Генерация целочисленного массива
int[] GenerateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

// Генерация массива вещественных чисел
double[] GenerateRandomFloatArray(int size, int min, int max)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(min, max + 1)) + new Random().NextDouble();
    }

    return array;
}

// Вывод целочисленного массива в коносль
void ShowArray(int[] arr, string Separator = " ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(Separator);
    }
    Console.WriteLine();
}

// Вывод массива вещественных чисел
void ShowFloatArray(double[] arr, int NumsAfterPoint, string Separator = "  ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i], NumsAfterPoint));
        if (i < arr.Length - 1) Console.Write(Separator);
    }
    Console.WriteLine();
}

// Подсчёт количества четных чисел в массиве
int EvenNumbers(int[] array)
{
    int counter = 0;                            //Задаём счётчик чётных чисел, изначально = 0

    for (int i = 0; i < array.Length; i++)      // Пробегаем по всему массиву
        if (array[i] % 2 == 0) counter++;       // Если текущий элемент чётный, то счётчик увеличиваем на 1

    return counter;                             // Возвращаем количество в основную программу
}

// Подсчёт суммы элементов на нечётных позициях массива
int OddElementsSum(int[] array)
{
    int sum = 0;                                // Изначально сумма равна нулю

    for (int i = 1; i < array.Length; i += 2)       // Пробегаем по нечётным позициям с шагом 2, начиная с 1
        sum += array[i];

    return sum;                                 // Возвращаем подсчитанную сумму в основную программу
}

// Находим минимальный элемент в массиве
double MinElement(double[] array)
{
    double result = array[0];                       //Предполагаем, что минимум - первый элемент массива

    for (int i = 1; i < array.Length; i++)          // Первый элемент рассмотрен, поэтому проверяем начиная со второго
        if (array[i] < result) result = array[i];   // Если текущий элемент меньше текущего минимума, то запоминаем его

    return result;                                  // Передаём в основную программу
}

// Находим максимальный элемент в массиве
double MaxElement(double[] array)
{
    double result = array[0];                       //Предполагаем, что максимум - первый элемент массива

    for (int i = 1; i < array.Length; i++)          // Первый элемент рассмотрен, поэтому проверяем начиная со второго
        if (array[i] > result) result = array[i];   // Если текущий элемент больше текущего максимума, то запоминаем его

    return result;                                  // Передаём в основную программу
}

// Задача 1

// Генерируем целочисленный массив с трёхзначными целыми числами
int SizeArray = new Random().Next(10, 20);         // Размер массива
int MinNumArray = 100;                             // Нижняя граница случайных чисел
int MaxNumArray = 999;                             // Верхняя граница случайных чисел

int[] myArray = GenerateRandomArray(SizeArray, MinNumArray, MaxNumArray);
Console.Clear();
Console.WriteLine("Задание 1");
Console.WriteLine("Исхдодный массив: ");
ShowArray(myArray, ", ");
Console.WriteLine("Количество чётных элементов: " + EvenNumbers(myArray) + "\n");

// Задача 2
// Генерируем целочисленный массив с трёхзначными целыми числами
SizeArray = new Random().Next(3, 7);                // Размер массива
MinNumArray = -99;                                  // Нижняя граница случайных чисел
MaxNumArray = 100;                                  // Верхняя граница случайных чисел

myArray = GenerateRandomArray(SizeArray, MinNumArray, MaxNumArray);
Console.WriteLine("Задание 2");
Console.WriteLine("Исхдодный массив: ");
ShowArray(myArray);
Console.WriteLine("Сумма элементов на нечётных позициях: " + OddElementsSum(myArray) + "\n");

// Задача 3
// Генерируем целочисленный массив с трёхзначными целыми числами
SizeArray = new Random().Next(5, 10);               // Размер массива случайный, от 5 до 10
MinNumArray = -99;                                  // Нижняя граница случайных чисел
MaxNumArray = 100;                                  // Верхняя граница случайных чисел

double[] myFloatArray = GenerateRandomFloatArray(SizeArray, MinNumArray, MaxNumArray);
Console.WriteLine("Задание 3");
Console.WriteLine("Исхдодный массив: ");
ShowFloatArray(myFloatArray, 2);
double min = MinElement(myFloatArray);
double max = MaxElement(myFloatArray);
Console.WriteLine("Максимальный элемент = " + Math.Round(max, 2) + ", минимальный элемент =" + Math.Round(min, 2));
Console.WriteLine("Разница между минимальным и максимальным элементами = " + Math.Round(max - min, 2));