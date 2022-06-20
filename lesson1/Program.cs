Console.Clear();
Console.WriteLine("For exit enter 0");
Console.Write("Enter number of task (2,4,6,8): ");
int taskNumber = Convert.ToInt32(Console.ReadLine());
while (taskNumber != 0)
{
if (taskNumber == 2)
{
// -------------------------------------Задача №2--------------------------------------------------------------------
Console.WriteLine("Определение минимума и максиума из двух чисел");
Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());     //Вводим первое число

Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());     //Вводим второе число

if (num1 > num2)    // Если num1 больше, то оно максимальное, а num2 - минимальное
{
    Console.WriteLine("max = " + num1 + " min = " + num2 + "\n");
}
else                // Иначе ...
    if (num1 < num2)    // Если num2 больше, то оно максимальное, а num1 - минимальное
    {
        Console.WriteLine("max = " + num2 + " min = " + num1 + "\n");
    }
    else // Предыдущие два условия не сработали => числа равны
    {
        Console.WriteLine("max = min = " + num1 + "\n");
    }

// Задача №2 - конец--------------------------------------------------------
}

if (taskNumber == 4)
{
// -------------------------------------Задача №4----------------------------------------------------------------

Console.WriteLine("Определение максиума из трёх чисел");
Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());     //Вводим первое число

Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());     //Вводим второе число

Console.Write("Input number three: ");
int num3 = Convert.ToInt32(Console.ReadLine());     //Вводим третье число

int max = num1;     // Предполагаем, что первое число - искомый максимум

// Сравниваем текущий максимум со вторым числом...
if (max < num2) 
{
    max = num2; // ...и если второе число больше, то его значение теперь является максимумом
}
// Сравниваем текущий максимум с третьим числом...
if (max < num3) 
{
    max = num3; // ...и если третье число больше, то его значение теперь является максимумом
}

// Выводим ответ на экран
Console.WriteLine("max = " + max + "\n");
}
// Задача №4 - конец ------------------------------------------------------------

if (taskNumber == 6)
{
// -------------------------------------Задача №6-----------------------------------------------------------------------

Console.WriteLine("Определение чётности/нечётности введеённого числа");
Console.Write("Input number : ");
int num = Convert.ToInt32(Console.ReadLine());     //Вводим число

if (num % 2 == 0)
{
    Console.WriteLine("Yes\n");  // Число чётное
}
else
{
    Console.WriteLine("No\n");    // Число нечётное
}
// Задача №6 - конец ---------------------------------------------------------------------
}

if (taskNumber == 8)
{
//-------------------------------------Задача №8-------------------------------------

Console.WriteLine("Вывод чётных чисел в дапазоне от 1 до N");
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());     //Вводим число N

int counter = 2; // 1 - нечётное число, заведомо выведено не будет, поэтому начинаем с двойки

while (counter <= N) 
{
    Console.Write(counter + " ");
    counter += 2;   // Переходим на два вперёд, т.к. за четным следует нечетное, котрое не годится
}

Console.WriteLine("\n"); // Переходим на новую строку, чтобы ответ не сливался со строкой терминала

// Задача №8 - конец ------------------------------------------------------------------------------
/*  Здесь можно было перед циклом присвоить counter = 1 и с шагом +1 проверять каждое его значение до N включительно
    на чётность/нечётность. Но это лишние шаги, которые при большом значении N существенно увеличат время работы */
}
Console.WriteLine("For exit enter 0");
Console.Write("Enter number of task (2,4,6,8): ");
taskNumber = Convert.ToInt32(Console.ReadLine());
}