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

// Подсчёт количества положительных элементов массива в цикле
int CountPositiveNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) result++;

    return result;
}

// Подсчёт количества положительных элементов массива рекурсивно
int CountPositiveNumbersRecursion(int[] arr, int pos)
{
    if (pos + 1 >= arr.Length)              // Если достигнут конец массива
    {
        if (arr[pos] > 0) return 1;         // то просто возвращаем 1
        else return 0;                     // или 0
    }
    else                                    // Конец массива не достигнут
    {                                       // метод вызывает сам себя с перемещением на следующий элемент массива
        if (arr[pos] > 0) return 1 + CountPositiveNumbersRecursion(arr, pos + 1);
        else return 0 + CountPositiveNumbersRecursion(arr, pos + 1);
    }
}

// Ввод исходных данных для прямой
// Методу задаётся номер прямой, а возвращает он массив из двух элементов (k,b)
double[] InputLineNumbers(int LineNumber)
{
    double[] mas = new double[2];
    Console.WriteLine("Прямая " + LineNumber);
    Console.Write("Коэффициент при х: ");
    mas[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Свободный член: ");
    mas[1] = Convert.ToDouble(Console.ReadLine());
    return mas;
}

// Метод проверяет две прямые и выдёт один из трёх возможных вариантов:
// 0 - прямые пересекаются, 1 - прямые параллельны, 2 - прямыесовпадают
int KindOfLines(double[] FirstLine, double[] SecondLine)
{
    int result = 0;             // Предполагаем, что прямые пересекаются

    if (FirstLine[0] == SecondLine[0] && FirstLine[1] == SecondLine[1]) result = 2; // Прямые совпадают

    if (FirstLine[0] == SecondLine[0] && FirstLine[1] != SecondLine[1]) result = 1; // Прямые параллельны

    return result;
}

// Метод получает на вход данные двух прямых
// И выдаёт координаты точки их пересечения
double[] IntersectionPoint(double[] FirstLine, double[] SecondLine)
{
    double[] result = new double[2];

    // Сначала находим значение координаты по Х
    result[0] = (SecondLine[1] - FirstLine[1]) / (FirstLine[0] - SecondLine[0]);

    // По найденному значению координаты по Х находим координату по Y
    result[1] = SecondLine[0] * result[0] + SecondLine[1];

    return result;
}

// -------------------------------- Задача 1
Console.Clear();
Console.WriteLine("----------Задача 1----------");
Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());                // Задаём длину массива
int[] array = InputArray(M);                                // Вводим массив с клавиатуры

Console.WriteLine("\nИсходный массив:");
ShowArray(array);
Console.WriteLine("Введено элементов больше нуля (поиск в цикле)     : " + CountPositiveNumbers(array));
Console.WriteLine("Введено элементов больше нуля (рекурсивный поиск) : " + CountPositiveNumbersRecursion(array, 0));
Console.WriteLine();

// -------------------------------- Задача 2
Console.WriteLine("----------Задача 2----------");
double[] LineOne = InputLineNumbers(1);                     // Вводим исходные данные первой прямой
double[] LineTwo = InputLineNumbers(2);                     // Вводим исходные данные второй прямой

int k = KindOfLines(LineOne, LineTwo);

if (k == 0)
{
    double[] answer = IntersectionPoint(LineOne, LineTwo);      // Находим координаты точки пересечения
    Console.WriteLine($"Прямые пересекаются в точке: ({answer[0]:0.00}; {answer[1]:0.00})");
}
else if (k == 1) Console.WriteLine("Прямые параллельны - не пересекаются");
else Console.WriteLine("Прямые совпадают - точек пересечения бесконечное множество");