﻿// https://github.com/dredbeard84

//		“Новичок”


// 1. Напишите программу, которая выводит на экран "Hello, World!".

//Console.Write("Hello, World!");


// 2. Напишите программу, которая запрашивает у пользователя его имя и выводит на экран приветствие с использованием введенного имени.

//Console.Write("Введите Ваше имя: ");
//Console.WriteLine($"Привет, {Console.ReadLine()}!");


// 3. Напишите программу, которая находит сумму двух чисел, введённых пользователем, и выводит результат на экран.

//int sum = 0;
//for (int i = 1; i <= 2; i++)
//{
//    Console.Write($"Введите {i}-е число: ");
//    int num = int.Parse(Console.ReadLine());
//    sum += num;
//}
//Console.WriteLine($"Сумма чисел: {sum}");


// 4. Напишите программу, которая определяет, является ли введённое пользователем число чётным или нечётным.

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//string res = (num % 2 == 0) ? "Число чётное" : "Число нечётное";
//Console.WriteLine(res);


// 5. Напишите программу, которая находит наибольшее число из трёх введённых пользователем чисел и выводит его на экран.

//Console.WriteLine("Введите 3 числа: ");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());
//Console.Write("Наибольшее число: ");
//if (num1 > num2 && num1 > num3)
//    Console.WriteLine(num1);
//else if (num1 < num2 && num2 > num3)
//    Console.WriteLine(num2);
//else
//    Console.WriteLine(num3);



//		“База”


// 6. Напишите программу, которая вычисляет факториал введённого пользователем числа и выводит результат на экран.

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//long fact = 1;
//for (int i = 1; i <= num; i++)
//{
//    fact *= i;
//}
//Console.WriteLine($"{num}! = {fact}");


// 7. Напишите программу, которая находит сумму всех чисел от 1 до 100 и выводит результат на экран.

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    sum += i;
//}
//Console.WriteLine($"Сумма всех чисел от 1 до 100 : {sum}");


// 8. Напишите программу, которая считывает строку с клавиатуры и выводит на экран количество символов в этой строке.

//Console.Write("Введите строку: ");
//string userString = Console.ReadLine();
//Console.WriteLine(userString.Length);


// 9. Напишите программу, которая проверяет, является ли введённое пользователем число простым (имеет только два делителя - 1 и само число).

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//int k = 0;
//for (int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        k++;
//    }
//}
//if (k == 0)
//{
//    Console.Write("Число простое");
//}
//else
//{
//    Console.Write("Число не является простым");
//}


// 10. Напишите программу, которая находит среднее арифметическое трёх чисел, введённых пользователем, и выводит результат на экран.

//double sum = 0;
//for (int i = 1; i <= 3; i++)
//{
//    Console.Write($"Введите {i}-е число: ");
//    double num = double.Parse(Console.ReadLine());
//    sum += num;
//}
//Console.WriteLine($"Среднее арифметическое чисел: {sum / 3:F2}");


// 11. Напишите программу, которая находит наименьшее число из трёх введённых пользователем чисел и выводит его на экран.

//Console.WriteLine("Введите 3 числа: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//Console.Write("Наименьшее число: ");
//if (a < b && a < c)
//{
//    Console.WriteLine(a);
//}
//else if (a > b && b < c)
//{
//    Console.WriteLine(b);
//}
//else
//{
//    Console.WriteLine(c);
//}


// 12. Напишите программу, которая выводит строку введённую пользователем в обратном порядке.

//Console.Write("Введите строку: ");
//string userString = Console.ReadLine();
//for (int i = userString.Length - 1; i >= 0; i--)
//{
//    Console.Write(userString[i]);
//}


// 13. Напишите программу, которая определяет, является ли введённое пользователем число палиндромом (читается одинаково слева направо и справа налево).

//Console.Write("Введите слово: ");
//string userString = Console.ReadLine();
//string reverseString = "";
//for (int i = userString.Length - 1; i >= 0; i--)
//{
//    reverseString += userString[i];
//}
//if (userString == reverseString)
//{
//    Console.WriteLine("Палиндром");
//}
//else
//{
//    Console.WriteLine("Не палиндром");
//}


//	“Любитель”


// 14. Напишите программу, которая определяет, является ли введённое пользователем число совершенным (сумма всех делителей числа равна самому числу).

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        sum += i;
//    }
//}
//if (sum == num)
//{
//    Console.WriteLine("Число совершенное");// 2, 3, 5, 7, 13, 17, 19, 31, 61, 89, 107
//}
//else
//{
//    Console.WriteLine("Число несовершенное");
//}


// 15. Напишите программу, которая находит все простые числа от 1 до 100 и выводит их на экран.

//for (int i = 1; i <= 100; i++)
//{
//    int k = 0;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            k++;
//        }
//    }
//    if (k == 0)
//    {
//        Console.Write(i + " ");// 1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
//    }
//}


// 16. Напишите программу, которая находит сумму всех чётных чисел от 1 до 100 и выводит результат на экран.

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);// 2550


// 17. Напишите программу, которая проверяет, является ли введённое пользователем слово панграммой (содержит все буквы алфавита).

//string abc = "abcdefghijklmnopqrstuvwxyz";
//string str = Console.ReadLine();
//bool isPangram = abc.All(str.Contains);
//Console.WriteLine(isPangram);


// 18. Напишите программу, которая находит наименьшее общее кратное (НОК) двух чисел, введённых пользователем, и выводит результат на экран.

//Console.WriteLine("Введите два целых числа: ");
//int m = int.Parse(Console.ReadLine()!);
//int n = int.Parse(Console.ReadLine()!);
//int temp = m * n;
//while (m != 0 && n != 0)// алгоритм Евклида (через деление) от while до nod
//{
//    if (m > n)
//    {
//        m %= n;
//    }
//    else
//    {
//        n %= m;
//    }
//}
//int nod = m + n;
//int nok = temp / nod;
//if (nok != 0)
//{
//    Console.WriteLine($"НОК = {nok}");
//}
//else
//{
//    Console.WriteLine("Введите целые положительные числа!");
//}


// 19. Напишите программу, которая считывает числа с клавиатуры, пока пользователь не введёт отрицательное число, и выводит сумму введённых положительных чисел на экран.



//		“Зануда”


// 20. Создайте одномерный массив длиной 8 элементов, вручную заполните его числами от -10 до 10.

//int[] mas = new int[8];
//Console.WriteLine("Введите числа:");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = int.Parse(Console.ReadLine()!);
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i] + " ");
//}


// 21. Найти сумму элементов в массиве.

//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    sum += mas[i];
//}
//foreach (int i in mas)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"Сумма элементов массива = {sum}");


// 22. Подсчитать количество чётных чисел в массиве.

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int count = 0;
//foreach (int i in mas)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Чётных чисел в массиве: {count}");


// 23. Определить наибольший и наименьший элемент в массиве.

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int min = mas[0];
//int max = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] > max)
//    {
//        max = mas[i];
//    }
//    if (mas[i] < min)
//    {
//        min = mas[i];
//    }
//}
//Console.WriteLine($"Max = {max}");
//Console.WriteLine($"Min = {min}");


// 24. Проверить, является ли массив “палиндромом”. Да да, числовой массив.

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//string strMas = "";
//string reverseMas = "";
//foreach (int i in mas)
//{
//    strMas += i.ToString() + " ";
//}
//for (int i = strMas.Length - 1; i >= 0; i--)
//{
//    reverseMas += strMas[i];
//}
//if (strMas == reverseMas)
//{
//    Console.WriteLine("Палиндром");
//}
//else
//{
//    Console.WriteLine("Не палиндром");
//}


// 25. Создайте двумерный массив длиной 5х5 элементов, вручную заполните его числами от -10 до 10.



// 26. Вычислить сумму элементов в каждой строке.



//		“Профи”

// 27. Найти сумму элементов по диагонали матрицы.


// 28. Создать массив массивов.


// 29. Найти среднее арифметическое для каждого подмассива.


// 30. Поменять местами строки в подмассивах.


// 31. Найти наибольший и наименьший элементы в каждом подмассиве.


// 32. Написать локальную функцию принимающую два числа и возвращающую их произведение.


// 33. Реализовать локальную функцию для проверки, является ли число простым.


// 34. Написать локальную функцию для проверки, является ли строка палиндромом. Да, можно скопировать.


//		“Программист”


// 35. Написать локальную функцию для вычисления факториала числа.


// 36. Создать локальную функцию для нахождения наибольшего общего делителя двух чисел.


// 37. Создать класс для представления геометрической фигуры (например, прямоугольника) и методы для вычисления её периметра и площади.


// 38. Реализовать класс для работы с числами и методы для выполнения арифметических операций.


// 39. Написать класс для управления банковским счётом с методами для пополнения и снятия средств.


// 40. Реализовать класс для работы с матрицами и методы для выполнения операций сложения, умножения и транспонирования.


//		“Босс”


/* Дан массив чисел 3Х3 со значениями от 1 до 10.
Задача:
Написать метод проверяющий, является ли данный числовой массив - магическим квадратом и возвращающий true если это так и false в противном случае.
Магический квадрат - матрица (или массив), в котором: суммы всех элементов каждой из строк, суммы всех элементов каждого столбца и суммы диагоналей равны.
Пример магического квадрата:
2 7 6
9 5 1
4 3 8
Все суммы здесь равны 15 */

