// Урок 10-1

// операция "исключающее или"
//int a = 249;
//Console.WriteLine(a ^ 8);// если а = 249, то результат 241
//Console.WriteLine(Convert.ToString(a ^ 8, 2));// 11110001

//// инверсия
//Console.WriteLine(Convert.ToString(a, 2));// преобразование а, равное 249, в двоичную систему
//Console.WriteLine(Convert.ToString(~a, 2));// инверсия

//// сдвиг
//Console.WriteLine(16 >> 3);// сдвиг вправо - быстрое извлечение корня = корень 3 ст. из 16 = 2
//Console.WriteLine(2 << 3);// сдвиг влево - быстрое возведение в степень = 2^3 = 16





// УСЛОВНЫЕ ОПЕРАТОРЫ
/*
 * Логические (л/) операции
 * 
 * 1) Операции отношения
 * <   >   <=  >=  ==  !=
 * 
 * 2) Логические операции
 * &    && (л/умножение)    |    || (л/сложение) ! (л/отрицание)    ^ (исключающее или)
 * 
 * 3) Приоритет операций
 * !    &&      ||^
 */

//// #3.11
//// a
//int x = 1, y = -1;
//Console.WriteLine(x * x + y * y <= 4);// true
//// б
//x = 1; y = 2;// точка с запятой для переопределения переменных
//Console.WriteLine(x >= 0 || y * y != 4);// true
//// е
//x = 2; y = 1;
//Console.WriteLine(!(x * y < 0) && (y > x));// falce

//// #3.29 б
//Console.WriteLine((x<20)^(y<20));// false

//// #3.31
//Console.Write("Введите N: ");
//int N = int.Parse(Console.ReadLine());
//Console.WriteLine(N % 5 == 0 || N % 7 == 0);
//Console.WriteLine(N % 4 == 0 && N % 10 != 0);

//// #3.32
//Console.Write("ВВедите Х: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите Y: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine((x >= 2) && (y >= 1 || y <= -1.5));

//// #3.33 г
//Console.Write("ВВедите Х: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите Y: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine(x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5);





//// ОПЕРАТОРЫ ВЕТВЛЕНИЯ
//Console.Write("ВВедите Х: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите Y: ");
//double y = double.Parse(Console.ReadLine());
//if (x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5)
//     Console.WriteLine("Попал");
//else Console.WriteLine("Не попал");



// #3.34
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());
Console.Write("d = ");
int d = int.Parse(Console.ReadLine());
// а - ладья
//Console.WriteLine((a == c) || (b == d));

// б - слон
//Console.WriteLine((a - b == c - d) || (a + b == c + d));

// в - король
//Console.WriteLine(Math.Abs(a - c) == 1);// || Math.Abs(b - d) == 1
Console.WriteLine((Math.Abs(a - c) == 1));



// корень из x  = Math.Sqrt(x);
// Х^7          = Math.Pow(x, 7);
// sin x        = Math.Sin(x);
// |x|          = Math.Abs(x);

// practice
//Console.Title = "Тема 10";
//Console.Write("Введите первое число: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine(Math.Max(x, y));// вывод наибольшего числа
//Console.WriteLine($"|{x}| = {Math.Abs(x)}\n|{y}| = {Math.Abs(y)}");
//Console.WriteLine(Math.Floor(x));
//Console.WriteLine(Math.Ceiling(x));
//Console.WriteLine($"{Math.Sqrt(x):F2}");
//Console.WriteLine(Math.DivRem((int)x, (int)y));// не принимает double
