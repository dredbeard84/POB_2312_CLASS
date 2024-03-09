//// Тема 5. Константы и литералы


////Задача 2.8
//Console.Write("Введите k: ");// в одну строку
//int k = int.Parse(Console.ReadLine());
//Console.Write("Введите номер дня недели 1 января: ");
//int d = int.Parse(Console.ReadLine());
//Console.WriteLine($"Номер дня недели:{(k + d - 1) % 7}");


//const float g = 9.8;// ошибка: 9.8 число, относящееся к вещественному типу данных,
//                    // которые по умолчанию относятся к double
//                    // для отнесения числа к типу float необходим литерал f
//const float g = 9.8f;
//const decimal d = 5.8m;// m (money) - литерал типа decimal


//// Градусы Цельсия в Кельвины и Фаренгейты
//const float K = 273.15f;// объявление константы для Кельвина
//const int FAR = 32;// объявление константы для Фаренгейта
//Console.Write("Введите температуру в градусах Цельсия: ");
//double t = double.Parse(Console.ReadLine());// присвоение значения для Цельсия
//double T = t + K;// формула расчёта для Кельвинов
//Console.WriteLine($"{t} C = {T:F2} K");
//double F = (t * 9 / 5) + FAR;// формула дя Фаренгейта
//Console.WriteLine($"{t} C = {F:F2} F");


//// Давление из Паскаль в бары, мм. рт ст, атм.
//// ввод данных с консоли
//Console.Write("Введите давление в Паскалях: ");
//// присвоение значения введённым данным
//double P = double.Parse(Console.ReadLine());
//// объявление константы
//const double BR = 1e-5;// бары
//const double RS = 7.50062e-3;// мм рт ст
//const double ATM = 1.01e-5;// атм
//// вывод результата с округлением до сотых (c формулой расчёта)
//Console.WriteLine($"{P} Па = {P * BR:F2} Бар");
//Console.WriteLine($"{P} Па = {P * RS:F2} мм рт ст");
//Console.WriteLine($"{P} Па = {P * ATM:F2} атм");


//// 2.10
//Console.Write("Введите двузначное число: ");
//int n = int.Parse(Console.ReadLine());
//int a = n % 10;
//Console.WriteLine($"Число единиц: {a}");
//int b = n / 10;
//Console.WriteLine($"Число десятков: {b}");
//Console.WriteLine($"Сумма цифр: {a + b}");
//Console.WriteLine($"Произведение цифр: {a * b}");


