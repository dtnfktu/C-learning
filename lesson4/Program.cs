// Метод находит сумму цифру из которых состоит зданное число
int SumOfNumbers(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;    // последнюю цифру числа прибавляем к переменной sum
        num /= 10;          // и отсекаем эту цифру
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
    // Создаём массив mas заданной длины len
    int[] mas = new int[len];

    // и заполняем его случайными числами
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

    // т.к. элементы массива выводятся в одной строке, по завершении вывода
    // делаем переход на новую строку
    Console.WriteLine();
}

// Инициализируем массив с помощью метода ArrayInit
int[] array = ArrayInit(ARRAY_LENGTH);

// Выводим массив на печать
Console.WriteLine("Your array is ...");
ArrayPrint(array);