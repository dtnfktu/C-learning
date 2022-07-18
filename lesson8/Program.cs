// Создание новой целочисленной матрицы с заданными параметрами
int[,] CreateRandomIntMatrix(int rows, int columns, int MinValue, int MaxValue)
{
    int[,] NewMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            NewMatrix[i, j] = new Random().Next(MinValue, MaxValue);

    return NewMatrix;
}

// Вывод матрицы на экран
void ShowMatrix(int[,] matrix, string title = "")
{
    Console.WriteLine(title);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write("{0,5:D} ", matrix[i, j]);
        Console.WriteLine();

    }
  
}

// Сортируем строки матрицы по убыванию пузырьковым методом
void SortMatrixLinesDesc(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)     // Проходим в цикле по строкам
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1 - k; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }
        } // for-k
    } // for-i
}

// Поиск строки с наименьшей суммой элемнтов --------------
// Отдельно ищем сумму элементов в заданной строке
int GetSumOnMatrixRow(int[,] matrix, int RowNumber)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[RowNumber, j];

    return sum;
}

// Метод возвращает индекс искомой строки
int GetMinSumMatrixRow(int[,] matrix)
{
    int IndexOfMin = 0;                                     // Предполагаем, что искомая строка - первая
    int SumOfMin = GetSumOnMatrixRow(matrix, IndexOfMin);   // А здесь сумма её элементов

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int TempSum = GetSumOnMatrixRow(matrix, i);
        if (TempSum < SumOfMin)
        {
            SumOfMin = TempSum;
            IndexOfMin = i;
        }
    }

    return IndexOfMin;
}

// Перемножение матриц -----------------------------------

// Проверяем две матрицы на соотвествие размеров
bool MatricesWithEqualsDimensions(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1);
}

// Перемножаем матрицы
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] NewMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix1.GetLength(1); j++)
            NewMatrix[i, j] = matrix1[i, j] * matrix2[i, j];

    return NewMatrix;
}

// Массив-зD ---------------------------------------------

//Создаём 3Д-массив с неповторяющимися двузначными числами
int[,,] CreateRandomIntArray3D(int Rows = 2, int Columns = 2, int Matrices = 2)
{
    int[] NumsArray = new int[90];
    for (int i = 0; i < 90; i++) NumsArray[i] = i + 10;     // Массив двузначных чисел 10..99

    int[,,] NewArray = new int[Rows, Columns, Matrices];    // Новый 3Д-массив

    for (int i = 0; i < Rows; i++)
    {
     for (int j = 0; j < Columns; j++)
     {
      for (int k = 0; k < Matrices; k++)
      {
        bool ValidNumber;
        int a;
        do                                                  // Здесь генерируем
        {                                                   // случайное двузначное число
            a = new Random().Next(10, 100);                 // и проверяем, встречалось ли оно ранее.
            ValidNumber = true;                             // Если да, то генерим по новой.
            if (NumsArray[a - 10] == 0) ValidNumber = false; // Если нет, то отмечаем его как использованное
                else NumsArray[a - 10] = 0;                  // для следующих генераций.
         } while (!ValidNumber);                            //
                
        NewArray[i, j, k] = a;
      }
     }
    }

    return NewArray;
}

// Выводим значения 3Д-массива
void ShowArray3D(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
             Console.Write($"{cube[i,j,k]}({i},{j},{k}) ");
             Console.WriteLine();
        }
        //Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем матрицу числами по спирали
void FillMatrixBySpiral(int[,] matrix)
{
    int CurrentNum = 1;                                         // Начальное значение
    int StopNum = matrix.GetLength(0) * matrix.GetLength(1);    // Условие остановки внешнего цикла
    int PosRow = 0;                                             // Начальная позиция по строкам
    int PosCol = 0;                                             // Начальная позиция по столбцам

     while (CurrentNum <= StopNum)
     {
        // Идём по верхней незаполненное строке слева направо
        while (CurrentNum <= StopNum && PosCol < matrix.GetLength(1) && matrix[PosRow, PosCol] == 0)  
            matrix[PosRow, PosCol++] = CurrentNum++;
        PosCol--; PosRow++;                                     // Корректируем текущее положение
        
        // Идём по крайнему правому незаполненному столбцу сверху вниз
        while (CurrentNum <= StopNum && PosRow < matrix.GetLength(0) && matrix[PosRow, PosCol] == 0)  
            matrix[PosRow++, PosCol] = CurrentNum++;
        PosRow--; PosCol--;                                     // Корректируем текущее положение
        
        // Идём по нижней незаполненной строке справа налево
        while (CurrentNum <= StopNum && PosCol >= 0 && matrix[PosRow, PosCol] == 0)  
            matrix[PosRow, PosCol--] = CurrentNum++;
        PosRow--; PosCol++;                                     // Корректируем текущее положение
        
        // Идём по крайнему левому незаполненному столбцу снизу вверх
        while (CurrentNum <= StopNum && PosRow >= 0 && matrix[PosRow, PosCol] == 0)  
            matrix[PosRow--, PosCol] = CurrentNum++;
        PosRow++; PosCol++;
        
    }

}

void FillMatrixBySpiralInRecursion(int[,] array2d, int Number = 1, int RowPos = 0, int ColPos = 0, byte Direction = 1)
{
    if (array2d[RowPos, ColPos] == 0)
    {
        array2d[RowPos, ColPos] = Number;       // Заполняем текущий элемент полученным числом

        // Определяем в каком направлении будет следующий шаг

        // Если текущее направление слева направо
        if (Direction == 1)
        {
            if (ColPos + 1 < array2d.GetLength(1) && array2d[RowPos, ColPos + 1] == 0) 
                FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos, ColPos + 1, Direction);
            else FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos + 1, ColPos, 2);
        }

        // Если текущее направление сверху вниз
        if (Direction == 2)
        {
            if (RowPos + 1 < array2d.GetLength(0) && array2d[RowPos + 1, ColPos] == 0)
                FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos + 1, ColPos, Direction);
            else FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos, ColPos - 1, 3);
        }

        // Если текущее направление справа налево
        if (Direction == 3)
        {
            if (ColPos - 1 >= 0 && array2d[RowPos, ColPos - 1] == 0)
                FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos, ColPos - 1, Direction);
            else FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos - 1, ColPos, 4);
        }

        // Если текущее направление снизу вверх
        if (Direction == 4)
        {
            if (array2d[RowPos - 1, ColPos] == 0)
                FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos - 1, ColPos, Direction);
            else FillMatrixBySpiralInRecursion(array2d, Number + 1, RowPos, ColPos + 1, 1);
        }


    }
}

Console.Clear();
Console.WriteLine("-------------- Задача 1 (54) --------------");
int rows = new Random().Next(4, 10);
int cols = new Random().Next(4, 10);
int min = 1;
int max = new Random().Next(2, 100);

int[,] Matrix = CreateRandomIntMatrix(rows, cols, min, max);
ShowMatrix(Matrix,"Исходная матрица:");
SortMatrixLinesDesc(Matrix);
ShowMatrix(Matrix,"Матрица с отсортированными по убыванию строками:");

Console.WriteLine("\n-------------- Задача 2 (56) --------------");
Console.WriteLine("Рассматриваем матрицу из задачи 1");
Console.WriteLine("Искомая строка №" + GetMinSumMatrixRow(Matrix) + "\n");
Console.WriteLine("Чтобы убедиться:");
for (int i = 0; i < Matrix.GetLength(0); i++)
 Console.WriteLine($"Строка №{i}, сумма элементов = {GetSumOnMatrixRow(Matrix, i)}");

Console.WriteLine("\n-------------- Задача 3 (58) --------------");
Console.WriteLine("Исходные матрицы:");

int[,] matrix1 = CreateRandomIntMatrix(rows, cols, min, max);
ShowMatrix(matrix1, "Матрица #1: ");

int[,] matrix2 = CreateRandomIntMatrix(rows, cols, min, max);
ShowMatrix(matrix2, "Матрица #2: ");

if (MatricesWithEqualsDimensions(matrix1, matrix2)) 
    ShowMatrix(MultiplyMatrices(matrix1, matrix2),"Произведение матриц: ");
    else Console.WriteLine("Невозможно перемножить матрицы, т.к. они должны быть одинаковой размерности");

Console.WriteLine("\n-------------- Задача 4 (60) --------------");
int[,,] Array3D = CreateRandomIntArray3D(4,4,4);
Console.WriteLine("Трёхмерный массив:");
ShowArray3D(Array3D);

Console.WriteLine("\n-------------- Задача 5 (62) --------------");
//Matrix = CreateRandomIntMatrix(5, 5, 0, 0);
ShowMatrix(Matrix = CreateRandomIntMatrix(4, 4, 0, 0),"Исходная матрица: ");
FillMatrixBySpiral(Matrix);
ShowMatrix(Matrix,"Полученная матрица: ");
ShowMatrix(Matrix = CreateRandomIntMatrix(6, 5, 0, 0),"Обнуляем матрицу: ");
FillMatrixBySpiralInRecursion(Matrix);
ShowMatrix(Matrix,"Полученная матрица рекурсивным методом: ");