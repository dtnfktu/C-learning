// Длина массива
int ARRAY_LENGTH = 8;

/* Метод создаёт новый целочисленный массив заданной длины
   и заполняет случайными числами в диапазоне 0..99*/
int[] ArrayInit(int len)
{
    int[] mas = new int[len];
    for (int i = 0; i < len; i++)
    {
        mas[i] = new Random().Next(0, 100);
    }
    return mas;
}

/* Метод получает в качестве аргумента массив arr
   и выводит на печать его содержимое*/
void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.Clear();
// Инициализируем массив с помощью метода ArrayInit
int[] array = ArrayInit(ARRAY_LENGTH);

// Выводим массив на печать
ArrayPrint(array);

Console.WriteLine();