int SumOfNumbers(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("----- Task 1 -------");
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum is " + SumOfNumbers(number));

//----------------------- Задача 2

Console.WriteLine("----- Task 2 -------");
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

// Инициализируем массив с помощью метода ArrayInit
int[] array = ArrayInit(ARRAY_LENGTH);

// Выводим массив на печать
Console.WriteLine("You array is ...");
ArrayPrint(array);

Console.WriteLine();