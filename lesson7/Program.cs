// Генерация матрицы вещественных чисел с задаными исходными данными
double[,] CreateDoubleRandomArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min, max) + new Random().NextDouble();

    return array;
}

// Вывод матрицы вещественных чисел на экран с заданным загловком
void ShowDoubleArray(double[,] array, string title = "")
{
    Console.WriteLine(title);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2} ", array[i,j]);
        }
        Console.WriteLine();
    }
}

// Генерация двумерного массива случайных целых чисел. Размерность матрицы - случайная
int[,] CreateRandomIntArray(int MaxRows = 2, int MaxCols = 10, int MaxNumber = 100)
{
    int rows = new Random().Next(2, 10);            // Задаём количество строк матрицы
    int cols = new Random().Next(2, 10);            // Задаём количество столбцов матрицы
    int[,] NewArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            NewArray[i,j] = new Random().Next(0,MaxNumber);

    return NewArray;
}

// Вывод на экран сгенерированной матрицы
void ShowIntArray(int[,] PrintArray, string title = "")
{
    Console.WriteLine(title);
    for (int i = 0; i < PrintArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrintArray.GetLength(1); j++)
            Console.Write("{0,3:D} ", PrintArray[i,j]);
        Console.WriteLine();
    }
}

// Поиск элемента в массиве по заданным "координатам"
string FindElementInMatrix(int[,] array, int PosRow, int PosCol)
{
    string result = "";

    if (PosRow >= array.GetLength(0) || PosCol >= array.GetLength(1))
     result = "В данной матрице такого элемента нет";
    else result = "Элемент [" + PosRow + "," + PosCol + "] = " + Convert.ToString(array[PosRow, PosCol]); 

    return result;
}

// Вычисление среднего арифметического по столбцам
// Метод возвращает массив средних арифметических
double[] AverageNumsInColumns(double[,] matrix)
{
    double[] avg = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0.0;               // В эту переменную накапливаем сумму элементов по столбцу

        for (int i = 0; i < matrix.GetLength(0); i++)
            sum += matrix[i,j];

        avg[j] = sum / matrix.GetLength(0); // Делим полученную сумму на количество строк
    }

    return avg;
}


Console.Clear();
Console.WriteLine("------------- Задание 1 (Задача 47) -------------");

Console.Write("Количество строк матрицы = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов матрицы = ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Нижний порог значений элементов матрицы = ");
int MinNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхний порог значений элементов матрицы = ");
int MaxNumber = Convert.ToInt32(Console.ReadLine());

double[,] DoubleArray = CreateDoubleRandomArray(rows, cols, MinNumber, MaxNumber);
ShowDoubleArray(DoubleArray, "Сгенерирован массив вещественных чисел:");

Console.WriteLine("\n------------- Задание 2 (Задача 50) -------------");
int[,] IntArray = CreateRandomIntArray();
ShowIntArray(IntArray, "Рассматривается двумерный массив:");
Console.Write("Номер элемента по строке = ");
int RowPos = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер элемента по столбцу = ");
int ColPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElementInMatrix(IntArray, RowPos, ColPos));

Console.WriteLine("\n------------- Задание 3 (Задача 52) -------------");

DoubleArray = CreateDoubleRandomArray(rows, cols, MinNumber, MaxNumber);
ShowDoubleArray(DoubleArray, "Сгенерирована матрица вещественных чисел:");

Console.WriteLine("\nСреднее арифметическое каждого столбца:");
double[] AvgArray = AverageNumsInColumns(DoubleArray);

// Выводим массив средних арифметических
for (int i = 0; i < AvgArray.Length; i++)
    Console.Write("{0,6:F2} ", AvgArray[i]);
Console.WriteLine();