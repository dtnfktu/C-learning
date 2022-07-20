# C#, домашние задания

## Урок 1 - папка lesson1
*В первом задании в одном коде я сразу объединил все 4 задачи. При запуске предлагается ввести номер задачи (2,4,6,8) или ввести 0 для завершения работы.*
*Программки простенькие и маленькие, поэтому не хотелось каждую создавать как отдельный проект.*  
*А комментить три задачи, оставляя одну на выполнение - как-то тоже не очень...*

## Урок 2 - папка lesson2

VSC предложил Convert to Program.Main style program, я согласился))

*Вновь в одном коде объедены все задачи из задания. 
Для выбора номера задачи используется метод ***int Menu()***, возвращающий номер выбранного пользователем пункта.*  
*В зависимости от выбранного пункта оператором множественного выбора switch производится обработка той или иной задачи:*
* В первой задаче генерируется случайное трёхзначное число (диапазон от 100 до 999), выводится в консоль (надо же увидеть в каком числе ищем вторую цифру). После этого делением на 10 (операция /) отсекается последняя цифра, затем нахождением остатка от деления на 10 (операция %) получаем искомую цифру.
Используется метод ***int SecondOfThree(int num)***, которому в качестве параметра задаётся трёхзначное число,а в качестве результата обработки выводится найденная вторая цифра.
* Во второй задаче пользователю предлагается ввести целое число, которое затем передаётся в качестве параметра методу ***void ThirdNumber(int number)***. 
Если число меньше 100, то третьей цифры нет, о чём выводится сообщение в консоль. Если число больше или равно 100, то в цикле делением на 10 (операция /) от числа отсекаются последние цифры, пока не останутся первые три цифры от числа. В качестве результата выводится остаток от деления на 10 (операция %) полученного после работы цикла "огрызка".
* В третьей задаче пользователю предлагается ввести целое положительное число. которое в качестве параметра передаётся методу ***bool IsWeekEnd(int day)***. Т.к. пользователь может ввести число >7, то в методе сначала отсекаются все целые недели (% 7). После этого число сравнивается с 6 (суббота) и 0 (если получается Воскресенье, то при % 7 в остатке получаем 0).

## Урок 3 - папка lesson3

* В первой задаче определяется является ли введённое цило число палиндромом. Для этого реализован метод ***bool IsPalindrome(int Num)***, принимающий в качестве параметра заданное число, и выводящий в зависимрсти от результата значения *истина (true)* или *ложь (false)*. 

Данную задачу можно было решить проще: рассмотреть число как строку (тип *string*) и в цикле сравнить попарно первый символ с последним, второй с предпосленим и т.д. до центра строки. Но это "ленивое" решение))) Так же можно было создать вторую строку, сделать реверс и сравнить содержимое строк. Но это тоже не то...  
* Во второй задаче пользователь вводит координаты двух точек в трёхмерном пространстве, последовательно каждую составляющую. Затем метод ***double Pifagor3D(double x1, double y1, double z1, double x2, double y2, double z2)*** выдаёт расстояние между этими точками. Решение схоже с теоремой Пифагора, только не на плоскости, а в 3Д-пространстве.  
* Третья задача реализует метод ***void CubesTable(int n)***. Где на вход подаётся число N - правая граница таблицы кубов целых чисел, и далее последовательно в цикле через пробел выводятся кубы чисел.

## Урок 4 - папка lesson4

* Первая задача использует метод ***int SumOfNumbers(int num)***. В качестве исходного параметра методу задаётся целое число *num*, для которого находится сумма цифр, из которого оно состоит. Метод возвращает найденную сумму. Задача реализована в цикле, который работает до тех пор, пока от исходного числа не останется 0 (ноль). На каждом шаге производится деление на 10. При этом остаток от деления прибавляется к перемнной *sum*, являющeйся эдаким аккумулятором. Целое от деления записывается в исходную переменную и таким образом на каждом шаге исходное число становится на одну цифру короче.

* Вторая задача разбита на две подзадачи, каждая из которых реализована отдельным методом.  
Метод ***int[] ArrayInit(int len)*** создаёт массив типа *int* заданной длины *len* и возвращает созданный массив (или, вернее - ссылку на него). Массив заполняется поэлементно, в цикле, генератором псевдослучайных чисел *Random()* с заданным диапазоном значений от 0 до 99.  
Метод ***void ArrayPrint(int[] arr)*** получает в качестве входного аргумента целочисленный массив *arr* и выводит последовательно, в цикле, значения элементов через пробел в консоль.   
Для сравнения использован метод ***String.Join(" ", array)*** из библиотеки **C#**. Здесь методу задаются два аргумента: первый - разделитель между элементами массива (в данном случае - пробел), второй - сам массив.  

## Урок 5 - папка lesson5

* В первой и второй задачах используется метод ***int[] GenerateRandomArray(int size, int min, int max)***, в котором создается целочисленный массив. В качестве аргументов методу передаются размер массива *size*, минимальное возможное значение элемента массива *min*, максимальное возможное значение элемента массива *max*. Метод возвращает сгенерированный массив с заданными параметрами. Для вывода содержимого массива используется метод ***void ShowArray(int[] arr, string Separator = " ")***. В качестве параметров метод принимает массив целых чисел ***int[] arr***, а также разделитель между элементами ***Separator*** (здесь может быть запятая, тире, пробел, два пробела и т.д.), по умолчанию - пробел.
* В третьей задаче для генерации массива и вывода в консоль используются похожие методы, но адаптированные под тип **double**. Это метод ***double[] GenerateRandomFloatArray(int size, int min, int max)*** и ***void ShowFloatArray(double[] arr, int NumsAfterPoint, string Separator = "  ")***. Кроме того, в методе вывода вещественного массива используется дополнительный параметр *NumsAfterPoint*, задающий количество знаков после запятой (для более красивого вывода). Здесь у параметра *Separator* по умолчанию использется двойной пробел.
* При решении первой задачи используется метод ***int EvenNumbers(int[] array)***, принимающий в качестве параметра целочисленный массив и выдающий количество чётных элементов нём. Поиск чётных элементов осушествляется в цикле, каждый элемент проверяется на чётность остатком деления на 2 (num % 2 ==0).
* Во второй задаче используется метод ***int OddElementsSum(int[] array)***. Здесь входным параметром является целочисленный массив. В нём рассматривются только нечётные элементы: начиная с элемента с индексом 1, и далее в цикле с шагом +2 суммируются значения соответствующих элементов.
* Третья задача использует два метода ***double MinElement(double[] array)*** и ***double MaxElement(double[] array)*** для нахождения минимального и максимального значения элемента массива соответственно. Методы полностью идентичны, за исключением знака сравнения. Сравнение производится в цикле, поэлементно. Чтобы вывод был боле-мене красивым использован метод ***Math.Round(num, 2)*** от C#, которому в качестве второго параметра передаётся количество знаков после точки в вещественном числе, которые следует выводить в консоль.

## Урок 6 - папка lesson6

* Первая задача условно разбита на несколько подзадач:
1. Определение количества вводимых чисел. Здесь задаётся целочисленная переменная М, значение которой предлагается ввести через консоль. Данная операция производится в основном теле программы, т.к. нет смысла задавать отдельный метод.
2. Т.к. тема текущих занятий - массивы, то М элементов сначала заносятся в массив. Тип данных в условии не оговорён, поэтому используется массив из М элементов целого типа. Данные для массива вводятся пользователем с клавиатуры. Здесь используется метод ***int[] InputArray(int m)***, которому в качестве аргумента передаётся длина массива. В методе создётся целочисленный массив, в цикле заполняется - на каждом шаге пользоваетлю указывается какой по счёту элемент он вводит. Метод возвращает созданный массив. Для вывода массива в консоль используется метод из 5 урока ***void ShowArray(int[] arr, string Separator = " ")***.
3. Метод ***int CountPositiveNumbers(int[] arr)*** получает на вход целочисленный массив и возвращает количество положительных элементов в нём.Подсчёт производится в цикле *for* простым перебором всех элементов массива с сравнением каждого - если больше нуля, то подходит. Для сравнения используется рекурсивный метод ***int CountPositiveNumbersRecursion(int[] arr, int pos)***(всё-таки тема - массивы и рекурсия), в котором так же идёт подсчёт количества положительных элементов массива. Методу в качестве входных параметров помимо массива передаётся ещё индекс текущего элемента массива (изначально = 0). При рекурсивном вызове индекс увеличивается на единицу. 
* Вторая задача, на первый взгляд, выглядит довольно простой. При этом со своими подводными камнями.  
Необходимо определить координаты пересечения двух прямых на плоскости. Уравнение прямой имеет вид ***y(x) = kx + b***. При этом ***k*** - коэффициент при ***х***, определяющий угол наклона прямой относительно ***Ох*** (или ***Оу***), ***b*** - свободный член, определяющий смещение прямой по ***Ох*** относительно ***Оу***.   
Т.к. прямая задаётся двумя параметрами, используется массив типа *double* длиной 2, где элемент массива с индексом 0 хранит в себе значение ***k***, элемент с индексом 1 - значение ***b***. Для ввода данных испольуется метод ***double[] InputLineNumbers(int LineNumber)***, которому в качестве входного параметра передаётся номер прямой (для наглядности, можно и без него), а возвращается массив из двух вещественных элементов.  *Кстати, при вводе дробных чисел для разделения целой и дробной частей по умолчанию используется запятая.*

Когда мы рассматриваем две прямые на плоскости, для каждой из которых заданы свои ***k*** и ***b***, возможны три варианта их поведения: 1 - они пересекаются, 2 - они не пересекаются, т.е. параллельны, 3 - они совпадают (пересечением является бесконечное множество точек - сами прямые). Для определения какой из случаев для введённых параметров имеет место быть используется метод ***int KindOfLines(double[] FirstLine, double[] SecondLine)***, который в качестве входных параметров принимает ***k*** и ***b*** двух прямых, сравнивает их, и выдаёт своё "заключение". Если ***k1***=***k2*** и ***b1***=***b2*** - прямые совпадают (возвращается код 2), если ***k1***=***k2*** и ~~***b1***=***b2***~~ - прямые параллельны (возвращается код 1). Во всех остальных случаях прямые персекаются - возвращается код 0.  
Чтобы определить координаты точки пересечения двух прямых необходимо решить систему равнений  
![система уравнений](images/system.png)  
Для этого следует приравнять правые части уравнений и выразить *х* через всё остальное:  
![выразили х](images/x.png)  
Затем полученное значение *х* подставляем в любое из уравнений и находим значение *у*.  
Полученное выражение используется в методе ***double[] IntersectionPoint(double[] FirstLine, double[] SecondLine)***, которому входными параметрами передаются две прямые, а на выходе получаем координаты точки пересечения. Здесь, как нельзя кстати, пригождается проверка на параллельность/совпадение прямых - исключается деление на ноль. Возвращаемый массив состоит из двух элементов: элемент с индексом 0 - координата *х*, с индексом 1 - координата *у*.

## Урок 7 - папка lesson7

* В первом задании необходимо создать двумерный массив размером m×n, заполненный случайными вещественными числами. Задача состоит из двух подзадач: создания массива и вывод массива на экран.  
Для создания массива и заполнения случайными вещественными числами используется метод ***double[,] CreateDoubleRandomArray(int rows, int columns, int min, int max)***, который возвращает заданный массив. Методу передаётся количество строк *rows* и столбцов *columns*, а также нижняя и верхняя границы диапазона возможных вещественных чисел, которыми заполняется массив (*min* и *max* соответственно).  
Вывод массива в консоль осуществляется методом ***void ShowDoubleArray(double[,] array, string title = "")***. Методу передаётся двумерный массив вещественных чисел *array*. Второй, необязательный параметр *title* (по умолчанию - пустая строка), служит заголовком выводимого массива. При выводе массива в консоль используется форматирование **{0,6:F2}** (6 - количество позиций под элемент массива с выравниванием справа, F2 - количество знаков после запятой, 2 - количество знаков, F - указзывает, что выводится вещественное число). Форматированному выводу уделено особое внимание, т.к. при выводе матрицы желательно чтобы элементы и их разряды находились строго друг под другом - так легче воспринимать таблицу чисел.
* Во втором задании для создания двумерного целочисленного массива используется метод ***int[,] CreateRandomIntArray(int MaxRows = 2, int MaxCols = 10, int MaxNumber = 100)***, который возвращает целочисленную матрицу. В качестве входных параметров задаётся количество строк *MaxRows* (по умолчанию = 2), количество столбцов *MaxCols* (по умолчанию = 10), и верхняя граница диапазона генерируемых случайных целых чисел *MaxNumber* (по умолчанию = 100). Нижняя граница равна 0 (нулю). Т.е. рассматриваем матрицу неотрицательных целых чисел.  
Поиск элемента в массиве осуществляется методом ***string FindElementInMatrix(int[,] array, int PosRow, int PosCol)***. Функция является информативной, ее тип принят за *string*: при отсутствии элемента в массиве с заданными координатами возвращается соответствующее сообщение; если же элемент есть, то возвращается его значение (тип данных - *string*).  Условием отсутствия элемента массива является выход за пределы границ столбца или строки (как влево, так и вправо).
* При решении третьей задачи для генерации новой матрицы и вывода её на экран используются методы из предыдущей задачи. Методом ***double[] AverageNumsInColumns(int[,] matrix)*** определяется одномерный массив (вектор) значений среднего арифметического для каждого столбца целочисленной матрицы. Методу в качестве входного параметра передаётся двумерный массив целых чисел. Возвращает метод одномерный массив вещественных чисел (при нахождении среднего арифметического используется операция деления, т.е. не всегда ответом может быть целое число - скорее вещественное).  
*Можно было бы создать метод, принмающий в качестве входного параметра одномерный числовой массив, а возвращающий вещественное число - среднее арифметическое. Но **C#** не позволяет  взять отдельную строку (или стобец) из многомерного массива как результат работы встроенного метода - необходимо создавать новый одномерный массив, что потребует дополнительных манипуляций*.
## Урок 8 - папка lesson8
* В первой задаче для создания двумерного массива и вывода его на экран используются методы ***int[,] CreateRandomIntMatrix(int rows, int columns, int MinValue, int MaxValue)*** и ***void ShowMatrix(int[,] matrix, string title = "")*** соответственно из предыдущих уроков.  
Сортировка строк матрицы **по убыванию** производится методом ***void SortMatrixLinesDesc(int[,] matr)***. Методу в качестве входного параметра передаётся матрица, которую необходимо преобразовать. В цикле ***for*** по ***i*** перебираются строки. Использован пузырьковый метод, где каждая строка рассматривается как одномерный массив. Здесь может возникнуть вопрос - почему в цикле ***for*** по ***j*** изменяется j до *matr.GetLength(1) - 1 - k*? С *matr.GetLength(1) - 1* вроде понятно - это длина строки. Почему *- k*? За один проход по строке одно значение попадает на своё место. Всего таких проходов k = количеству элементов в строке. Если убрать *- k*, то на каждом шаге количество сравнений и перестановок будет одно и то же = длине строки. При этом *k* элементов уже будут на своих местах и сравнивать их смысла нет, пустая трата времени.  
Здесь для сортировки можно было бы использовать отдельный метод, получающий на вход индекс строки, и сортирующий её. Возможно, так удобнее - меньше вложенных циклов. Но я реализовал задачу так, и всё работает!)))
* Для решения второй задачи используются две функции. Первая, ***int GetSumOnMatrixRow(int[,] matrix, int RowNumber)***, получает на вход матрицу и номер строки, возвращает сумму элементов матрицы в указанной строке. Второй метод, ***int GetMinSumMatrixRow(int[,] matrix)*** используя метод нахождения суммы элементов в строке матрицы, возвращает индекс строки с минимальной суммой. В теле программы, для наглядности, выводятся суммы элементов по каждой строке, не стал оборачивать в отдельный метод (лень-матушка :/).  
* Третья задача. Требуется перемножить две матрицы, т.е. перемножить элементы с одинаковыми индексами двух заданных матриц. Для этого сначала методом ***bool MatricesWithEqualsDimensions(int[,] matrix1, int[,] matrix2)*** проверяем две матрицы на соответствие размерности, т.е. количество строк и количество столбцов у двух матриц должно совпадать. Иначе можем получить ошибку выхода индекса за пределы длины,ширины массива. Перемножение элементов матриц реализовано в методе ***int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)***.  
* В четвёртой задаче методом ***int[,,] CreateRandomIntArray3D(int Rows = 2, int Columns = 2, int Matrices = 2)*** создаётся 3-мерный массив, по умолчанию размер 2 х 2 х 2. Элементы массива - двузначные целые числа (от 10 до 99). При этом, значения, в соответствии с уловием задачи, не повторяются. Это условие реализовано в строках 115-123. Здесь было бы удобно использовать множество. Но для решения данной задачи вполне подходит одномерный массив длиной 90 (столько двузначных чисел всего), где 0-му элементу соответствует число 10, 1-му - 11 и т.д. При генерации нового числа идёт проверка в массиве (кстати, индекс вычисляется по формуле индекс = число - 10, нет необходимости пробегать по массиву). Если заданный элемент равен нулю, значит это число уже есть в трёхмерном массиве и генерируется новое случайное число до тех пор пока не окажется, что такого числа ещё не было. Если же число выпало впервые, то оно заносится в трёхмерный массив, а в одномерном массиве в соответствующую ячейку записывается ноль (у нас двузначные числа и ноль в это множество, по-любому, не попадает).  
Вывод элементов на экран осуществляется методом ***void ShowArray3D(int[,,] cube)***. Элементы выводятся построчно: само значение + в скобках координаты элемента в массиве.  ***Данная реализация для трёхмерного массива с общим количством элементов не больше 90***  
Пятая задача, на мой взгляд, самая интересная в данном наборе.   
Два варианта решения - циклами и с помощью рекурсии. Решение с циклами. Сначала создаётся матрица методом ***int[,] CreateRandomIntMatrix(int rows, int columns, int MinValue, int MaxValue)***, где минимальное и максимальное значения задаются равными нулю. В методе ***void FillMatrixBySpiral(int[,] matrix)*** реализовано заполнение матрицы по спирали. Условием остановки цикла является достижение текущего значения (которым заполняются элементы матрицы) предельного значения (оно равно произведению количества строк матрицы на количество столбцов). Четыре цикла поочерёдно заполняют элементы матрицы: 1 - верхняя строка слева направо, 2 - правый столбец сверху вниз, 3 - нижняя строка справа налево, 4 - левый столбец снизу вверх.  
Рекурсивное решение. За исходную так же берётся матрица, все элементы которой равны нулю. Методом ***void FillMatrixBySpiralInRecursion(int[,] array2d, int Number = 1, int RowPos = 0, int ColPos = 0, byte Direction = 1)*** осуществляется заполнение матрицы по спирали. При первом вызове методу передаётся только сама матрица. Начальные позиция, значение, направление задаются по умолчанию (заполнение всегда осуществляется числовым рядом, начинающимся с 1, всегда с позиции (0,0), в направлении слева направо).
## Урок 9 - папка lesson9
* В первой задаче необходимо найти количество цифр в числе N. Метод ***int GetNumberOfDigits(int N)*** рекурсивно выполняет подсчёт количества цифр. В качестве входного параметра методу задаётся рассматриваемое число. Входным числом может быть целое число, отличное от нуля, как положительное так и отрицательное - знак числа на результат не влияет. Метод вызывает сам себя, каждый раз уменьшая значение входного параметра на единицу. Условие остановки - метод получает на вход ноль. Но т.к. 0 (ноль) - это тоже число, состоящее из одной цифры, его игнорировать нельзя. Данная проблема решена в теле программы с использованием тернарного оператора (если задан ноль, то сразу выводится 1; иначе запускается рекурсивный подсчёт).
* Во второй задаче осуществляется подсчёт суммы целых чисел, находящихся между заданными значениями M и N (обе границы включаются в сумму). Методу ***int GetSumBetweenNumbers(int a, int b)*** на вход задаются левая и правая границы рассматриваемого ряда целых чисел. Пока значение *a* меньше значения *b* метод вызывает сам себя, при этом при каждом новом вызове левая граница смещается на +1 вправо.  
Передаваемые методу входные параметры должны соответствовать условию: первый параметр должен быть **не больше** второго. Здесь можно сначала выполнить проверку передаваемых параметров, а затем при вызове метода передать меньшее значение первым, большее значение - вторым. Проверка и рокировка значений переменных (при необходимости) вынесена в отдельный метод ***void ReplaceValues(ref int value1, ref int value2)***. Если значение первого входного параметра больше второго, то их содержимое меняется местами. По умолчанию при работе с  примитивными типами данных (int, double, bool и т.п.) в методы передаются их "копии", значения которых могут быть изменены внутри метода, но "снаружи" перемнные остаются неизменными. Чтобы содержимое переменных было изменено внутри метода использован модификатор доступа *ref*, с помощью которого передаются ссылки на "оригиналы".