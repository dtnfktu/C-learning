internal class Program
{
    private static void Main(string[] args)
    {
        // Вызов меню программы с возвращением выбранного пункта
        int Menu()
        {
            Console.WriteLine("Выберите номер задачи:");
            Console.WriteLine("1 - Найти вторую цифру трёхзначного числа");
            Console.WriteLine("2 - Найти третью цифру числа /если такая имеется/");
            Console.WriteLine("3 - Определить, является ли указанный день выходным");
            Console.WriteLine("0 - Завершить работу программы");
            return Convert.ToInt32(Console.ReadLine());
        }


        // Метод принимает трёхзначное число и, как результат выдаёт вторую цифру числа
        // Предполагаем, что число трехзначное и не требует по этому поводу дополнительной проверки
        int SecondOfThree(int num)
        {
            
            int result = num / 10 % 10;   // операцией / отсекаем последнюю цифру, операцией % отсекаем первую цифру
            return result;                  // возвращаем результат в основную программу
        }

        // Вывод третьей цифры заданного числа, либо сообщения, что третьей цифры нет
        void ThirdNumber(int number)
        {

        }

        // Определяем является ли заданный день недели выходным
        bool IsWeekEnd(int day)
        {
            day = day % 7; // на тот случай, если число больше 7
            return (day == 6) || (day == 0); // Если остаток от деления на 7 = 0 => число кратно семи, т.е. Воскресенье!
        }

        // Тело основной программы ---------------------------------------------------------
        Console.Clear();
        
        int taskNumber = Menu();

        while (taskNumber != 0)
        {
            switch(taskNumber) 
            {
                case 1 : 
                int randNum = new Random().Next(100, 1000);
                Console.WriteLine("Рассматривается число: " + randNum);
                Console.WriteLine("Вторая цифра: " + SecondOfThree(randNum));
                break;

                case 2 : 
                Console.Write("Введите целое число: ");
                int numb = Convert.ToInt32(Console.ReadLine());
                ThirdNumber(numb);
                break;

                case 3 :
                Console.Write("Введите день недели (целое положительное число): ");
                if (IsWeekEnd(Convert.ToInt32(Console.ReadLine())))
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
                break;
            }

            taskNumber = Menu();
        }
    }
}