// 1
//Console.WriteLine("Hello, World!");

// 2
//Console.Write("Введите Ваше имя: ");
//Console.WriteLine("Привет, " + Console.ReadLine() + "!");

// 3
//Console.Write("Введите 1-е число: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите 2-е число: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Сумма: {a + b}");

// 4
//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//string res = (num % 2 == 0) ? "чётное" : "нечётное";
//Console.WriteLine(res);

// 5
//Console.Write("Введите 1-е число: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Введите 2-е число: ");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите 3-е число: ");
//double z = double.Parse(Console.ReadLine());
//if (x > y && y > z) Console.WriteLine($"Наибольшее число: {x}");
//else if (y > z && z > x) Console.WriteLine($"Наибольшее число: {y}");
//else if (z > x && x > y) Console.WriteLine($"Наибольшее число: {z}");
//else if (z > y && y > x) Console.WriteLine($"Наибольшее число: {z}");

// 6
//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//long Fact = 1;
//int i = 1;
//while (i <= num) Fact *= i++;
//Console.WriteLine($"Факториал {num} = {Fact}");


// 7
//int n = 1;
//int sum = 0;
//for (int i = 1; i <= 100; sum += i, i++) ;
//Console.WriteLine(sum);

// 8
//Console.Write("Введите строку: ");
//string str = Console.ReadLine();
//Console.WriteLine(str.Length);

// 9


// 10


// 11
Console.Write("Введите х: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите z: ");
double z = double.Parse(Console.ReadLine());
if (x > y && y > z) Console.WriteLine(z);
else if (y > z && z > x) Console.WriteLine(x);
else if (z > x && x > y) Console.WriteLine(y);
else if (z > y && y > x) Console.WriteLine(x);

double min = Math.Min(x, y);
min = Math.Min(min, z);


// 12
//Console.Write("Введите строку: ");
//string str = Console.ReadLine();
//for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);

// 13
//Console.Write("Введите слово: ");
//string str = Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--) rts += str[i];
//if (str == rts) Console.Write("Палиндром");
//else Console.Write("Не палиндром");

// 14
