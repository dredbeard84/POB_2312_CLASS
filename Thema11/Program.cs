// Тема 11: Условные операторы


// практика 11_1

// тернарный оператор

//Console.Write("Введите число: ");
//double numberOne = double.Parse(Console.ReadLine());
//double numberTwo = (numberOne >= 0) ? x : -x;
//Console.WriteLine($"|{numberOne}| = {numberTwo}");

// 1
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//string res = (number % 2 == 0) ? "чётное" : "нечётное";
//Console.WriteLine(res);

// 3
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//if (number > 0) Console.WriteLine("положительное");// a
//else if (number < 0) Console.WriteLine("отрицательное");
//     else Console.WriteLine("равно нулю");

//Console.WriteLine((number > 0) ? "положительное" : (number < 0) ? "отрицательное" : "равно нулю");// b

// 4
//Console.Write("Введите первое число: ");
//int numberOne = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int numberTwo = int.Parse(Console.ReadLine());
//if (numberOne > numberTwo) Console.WriteLine($"наибольшее {numberOne}");
//else if (numberOne < numberTwo) Console.WriteLine($"наибольшее {numberTwo}");
//     else Console.WriteLine("равны");

//Console.WriteLine((numberOne > numberTwo) ? $"наибольшее {numberOne}" : (numberOne < numberTwo) ? $"наибольшее {numberTwo}" : "равны");

//string result = (numberOne > numberTwo) ? $"наибольшее {numberOne}" :
//    (numberOne < numberTwo) ? $"наибольшее {numberTwo}" : "равны";
//Console.WriteLine(result);


// ? - надо додумать
//Console.Write("Введите х: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите y: ");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите z: ");
//double z = double.Parse(Console.ReadLine());
//if (x > y && y > z) Console.WriteLine(z);
//else if (y > z && z > x) Console.WriteLine(x);
//     else if (z > x && x > y) Console.WriteLine(y);
//          else if (z > y && y > x) Console.WriteLine(x);

//double min = Math.Min(x, y);
//min = Math.Min(min, z);


// 5
//Console.Write("Введите рост: ");
//int h = int.Parse(Console.ReadLine());
//Console.Write("Введите вес: ");
//int m = int.Parse(Console.ReadLine());
//if (h - 100 < m) Console.WriteLine("избыток массы");
//else if (h - 100 > m) Console.WriteLine("недостаток массы");
//     else Console.WriteLine("нормальная масса");


// 6
//Console.Write("Ведете номер месяца: ");
//byte m = byte.Parse(Console.ReadLine());
//if (m == 12 || m == 1 || m == 2) Console.WriteLine("зима");
//else if (m == 3 || m == 4 || m == 5) Console.WriteLine("весна");
//else if (m == 6 || m == 7 || m == 8) Console.WriteLine("лето");
//else if (m == 9 || m == 10 || m == 11) Console.WriteLine("осень");
//else Console.WriteLine("ошибка ввода");


// 7
//Console.Write("Введите площадь окружности: ");
//double s1 = double.Parse(Console.ReadLine());
//Console.Write("Введите площадь квадрата: ");
//double s2 = double.Parse(Console.ReadLine());
//double a = Math.Sqrt(s2);// сторона квадрата
//double r = Math.Sqrt(s1 / Math.PI);// радиус окружности
//if (2 * r <= a) Console.WriteLine("круг поместится в квадрат");
//else Console.WriteLine("круг не поместится в квадрат");
//if (2 * r >= a * Math.Sqrt(2)) Console.WriteLine("квадрат поместится в круге");
//else Console.WriteLine("квадрат не поместится в круге");


//          08.02.24 класс Random


//Console.Write("Введите a: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c: ");
//double c = double.Parse(Console.ReadLine());

//double D = b * b - 4 * a * c;

//if (D > 0)
//{
//    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(D)) / (2 * b);
//    Console.WriteLine($"x1 = {x1:F2} x2 = {x2:F2}");
//}
//else if (D == 0)
//    {
//        double x = -b / (2 * a);
//        Console.WriteLine($"x = {x:F2}");
//    }
//     else Console.WriteLine("Корней нет");
// Время жизни переменной и область её действия определяется пределами блока { }


// практикум
// #1

//Console.Write("Введите год рождения: ");
//int year = int.Parse(Console.ReadLine());
//if (year % 4 == 0) Console.WriteLine("Високосный");
//else Console.WriteLine("Невисокосный");


// #2

//Console.Write("Введите число: ");
//double x = double.Parse(Console.ReadLine());
//if (x >= 10 && x <= 100) Console.WriteLine("Лежит");
//else Console.WriteLine("Не лежит");

// #5

//Random ramdom = new Random();// создание генератора случайных чисел
//int x = ramdom.Next(1, 11);// Next - метод, который генерирует только целые числа, в данном случае от 1 до 10
//Console.Write("Введите число от 1 до 10: ");
//int a = int.Parse(Console.ReadLine());
//if (a == x) Console.WriteLine("Вы угадали");
//else if (a < x) Console.WriteLine("Вы ввели меньшее число");
//else Console.WriteLine("Вы ввели большее число");

//Random random = new Random();
//double x = random.NextDouble()*10;// генерирует вещественные число в диапазоне от 0 до 1, *10 - задание диапазона от 0 до 9


// логин и пароль

//const string LOGIN1 = "administrator";
//const string LOGIN2 = "администратор";
//const int PASSWORD1 = 2807988;
//const string LOGIN3 = "Богдан";
//const int PASSWORD3 = 27111095;
//const string LOGIN4 = "Дмитрий";
//const int PASSWORD4 = 12021917;

//Console.Write("Введите логин: ");
//string login = Console.ReadLine();
//if (login == LOGIN1 || login == LOGIN2)
//{
//    Console.Write("Введите пароль: ");
//    int password = int.Parse(Console.ReadLine());
//    if (password == PASSWORD1) Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Вы ввели неправильный пароль");
//}
//else if (login == LOGIN3)
//{
//    Console.Write("Введите пароль: ");
//    int password = int.Parse(Console.ReadLine());
//    if (password == PASSWORD3) Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Вы ввели неправильный пароль");
//}
//else if (login == LOGIN4)
//{
//    Console.Write("Введите пароль: ");
//    int password = int.Parse(Console.ReadLine());
//    if (password == PASSWORD4) Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Вы ввели неправильный пароль");
//}
//else Console.Write("Такого логина не существует");


//Console.ForegroundColor = ConsoleColor.Green;// цвет консоли
//Console.WriteLine();


// #1
//Random random = new Random();
//int intColor = random.Next(3);
//string color;
//if (intColor == 0) color = "красный";
//else if (intColor == 1) color = "синий";
//else color = "зелёный";

//Console.Write("Введите цвет: ");
//string userColor = Console.ReadLine();
//if (userColor == color) Console.Write("Победа");
//else
//{
//    if (userColor == "красный") Console.Write("Раньше");
//    else if (userColor == "зелёный")
//    {
//        if (color == "красный");
//        else Console.WriteLine("Раньше");
//    }
//    else Console.WriteLine("Позже");
//}


// #2
//Random random = new Random();
//int year = random.Next(1900, 2024);
//Console.WriteLine(year);
//string result = (year % 4 == 0) ? "да" : "нет";
//Console.Write("Год високосный или нет (да/нет): ");
//string answer = Console.ReadLine();
//if (answer == result) Console.Write("Победа");
//else 
//{
//    if (year % 4 == 0) Console.WriteLine("Високосный");
//    else Console.WriteLine("Невисокосный");
//}


// #3
//Random random = new Random();
//int week = random.Next(1, 8);
//string day;
//if (week == 1) day = "понедельник";
//else if (week == 2) day = "вторник";
//     else if (week == 3) day = "среда";
//          else if (week == 4) day = "четверг";
//               else if (week == 5) day = "пятница";
//                    else if (week == 6) day = "суббота";
//                         else day = "воскресенье";

//Console.Write("Угадайте день недели: ");
//string userDay = Console.ReadLine();
//if (userDay == day) Console.Write("Молодец!");
//else Console.WriteLine($"Неверно - {day}");


// задачник 2.8
//Console.Write("Введите день недели 1 января: ");
//int d = int.Parse(Console.ReadLine());
//Console.Write("Введите число от 1 до 365: ");
//int k = int.Parse(Console.ReadLine());
//int n = (k + d) % 7 - 1;// формула?
//if (n == 1) Console.Write("понедельник");
//else if (n == 2) Console.Write("вторник");
//else if (n == 3) Console.Write("среда");
//else if (n == 4) Console.Write("четверг");
//else if (n == 5) Console.Write("пятница");
//else if (n == 6) Console.Write("суббота");
//else Console.Write("воскресенье");
