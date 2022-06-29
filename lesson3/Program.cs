// Метод определяет является ли заданное число num палиндромом
bool IsPalindrome(int Num)
{
    int muN = 0;                    // Зеркало числа изначально равно 0
    int n = Num;                    // Копия заданного числа, которую будем "кромсать"

    while (n != 0)                  // Цикл, пока от начального числа ничего не останется
    {
        muN = muN * 10 + n % 10;    // Повышаем порядок зеркала и прибавляем очередную цифру
        n /= 10;                    // то же самое что n = n / 10; - исходное число теряет последнюю цифру
    }

    if (muN == Num) return true;
        else return false;
}

//Определение расстояния между двумя точками, заданными координатами в трёхмерном пространстве
double Pifagor3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double ans = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return ans;
}

// Метод, возвращающий ряд кубов чисел для псоледовательности от 1 до n
void CubesTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
    Console.WriteLine();
}

// Вызов меню программы с возвращением выбранного пункта
int Menu()
{
    Console.WriteLine("\nВыберите номер задачи:");
    Console.WriteLine("1 - Определить, является ли введённое целое число палиндромом");
    Console.WriteLine("2 - Найти расстояние между двумя точками в трёхмерном пространстве");
    Console.WriteLine("3 - Вывести кубы чисел от 1 до N включительно");
    Console.WriteLine("0 - Завершить работу программы\n");
    Console.Write("Ваш выбор: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Тело основной программы ---------------------------------------------------------
Console.Clear();
        
int taskNumber = Menu();

while (taskNumber != 0)
{
    switch(taskNumber) 
    {
        case 1 : // Выбран пункт меню 1
        Console.WriteLine("Определяем яавляется ли число палиндромом...");
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Данное число палиндром: ");
        if (IsPalindrome(number)) 
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
        break;

        case 2 : // Выбран пункт меню 2
        Console.WriteLine("Определяем расстояние между точками...");

        Console.WriteLine("Введите координаты первой точки: ");
        Console.Write("x1 = ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("z1 = ");
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки: ");
        Console.Write("x2 = ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("z2 = ");
        double z2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Расстояние = " + Pifagor3D(x1, y1, z1, x2, y2, z2));
        break;

        case 3 :// Выбран пункт меню 3
        Console.WriteLine("Выводим кубы чисел...");

        Console.Write("Введите число N : ");
        int cube = Convert.ToInt32(Console.ReadLine());
        
        CubesTable(cube);
        break;
        }

        taskNumber = Menu();
}
Console.WriteLine("Завершение работы");