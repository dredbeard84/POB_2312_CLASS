//// Тема 3. Алгоритмические основы программирования. Работа со строками


////1.1 Вывести число "пи" с точностью до 100-х
//Console.WriteLine($"{Math.PI:F2}");

//// 1.2 Вывсти "e" с точностью до 10-х
//Console.WriteLine($"{Math.E:F1}");

//// 1.3 Программа вывода числа с клавы с сообщением "Вы ввели число"
//Console.WriteLine("Введите число");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {n}");

//// 1.5 Вывести на на одной строке числа 1, 13 и 49 с одним пробелом между ними
//Console.WriteLine($"{1} {13} {49}");

//// 1.6 Вывести на одной строке числа с двумя пробелами между ними
//Console.WriteLine($"{7}  {15}  {100}");
//Console.WriteLine("7  15  100");

//// 1.7 Программа вывода на экран трёх любых чисел в одну строку с 2-мя пробелами между ними
//Console.WriteLine("Введите первое число");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье число");
//int c = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}  {b}  {c}");

//// 1.9. Вывести на экран числа 50 и 10 одно под другим.
//// a)
//Console.WriteLine(50);
//Console.WriteLine(10);
//// b) \n - переход на новую стороку
//Console.WriteLine("50\n10");

// 1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
//Console.WriteLine("5\n10\n21");

//// 1.12. Составить программу вывода на экран следующей информации:
//// а)
//Console.WriteLine("5 10\n7 см");
//// б)
//Console.WriteLine("Введите переменную t");
//int t = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите переменную v");
//int v = int.Parse(Console.ReadLine());
//Console.WriteLine($"100 {t}\n1949 {v}");
//// в)
//Console.WriteLine("Введите переменную x");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите переменную y");
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine($"{x} 25\n{x} {y}");

//// 1.17
//// a)
//Console.WriteLine("Vvedite x1:");
//double x1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Vvedite x2:");
//double x2 = double.Parse(Console.ReadLine());
//double res = Math.Sqrt(x1 * x1 + x2 * x2);
//Console.WriteLine($"Resultat={res:F2}");

// б)
Console.WriteLine("Vvedite v0"); // 1
double v0 = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite a"); // 2
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Vvedite t"); // 3
double t = double.Parse(Console.ReadLine());
double s = v0 * t + (a * t * t) / 2;
Console.WriteLine($"Rezultat = {s:F2}"); // = 12

//// ж
//Console.WriteLine("Vvedite R");
//double R = double.Parse(Console.ReadLine());
//double L = 2 * Math.PI * R;
//Console.WriteLine($"Rezultat = {L:F2}");

//// 1.22
//try // попробовать
//{
//    Console.WriteLine("Vvedita x:");
//    double x = double.Parse(Console.ReadLine());
//    double y = 7 * x * x - 3 * x + 6;
//    Console.WriteLine($"y = {y:F2}");
//}
//catch (Exception e) // выловить ошибку
//{
//    Console.WriteLine(e.Message);
//}
