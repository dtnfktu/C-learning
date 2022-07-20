// Реурсивное определение количества цифр в числе
int GetNumberOfDigits(int N)
{
    if (N == 0) return 0;
     else return 1 + GetNumberOfDigits(N / 10);
}

// Метод меняет местами значения переменных
void ReplaceValues(ref int value1, ref int value2)
{
    if (value1 > value2)
    {
        int temp = value1;
        value1 = value2;
        value2 = temp;
    }
}

// Рекурсивный подсчёт суммы чисел
int GetSumBetweenNumbers(int a, int b)
{
    if (a == b) return b;
        else return a + GetSumBetweenNumbers(a + 1, b);
}


Console.Clear();
Console.WriteLine("---------------- Задача 1 (64) ----------------");
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр = " + (num == 0 ? 1 : GetNumberOfDigits(num)));

Console.WriteLine("\n---------------- Задача 2 (66) ----------------");
Console.Write("Введите значение M : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N : ");
int n = Convert.ToInt32(Console.ReadLine());

ReplaceValues(ref m, ref n);

Console.WriteLine($"Сумма чисел от {m} до {n} = {GetSumBetweenNumbers(m, n)}");