// Урок 24
// Тема 20: локальные функции

// задачник # 10.1 (a)

//double x = (Math.Sqrt(6) + 6) / 2 + 
//           (Math.Sqrt(13) + 13) / 2 + 
//           (Math.Sqrt(21) + 21) / 2;
//Console.WriteLine($"{x:F2}");

//x = Func(6) + Func(13) + Func(21);// фактический параметр

//double Func(int y)// формальный параметр
//{
//    return (Math.Sqrt(y) + y) / 2;
//}


// ЗАДАЧНИК

// # 10.3 (2)

//Console.Write("Введите a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//int b = int.Parse(Console.ReadLine());
//int z = max(a, 2 * b) * max(2 * a - b, b);
//Console.WriteLine(z);
//int max(int x, int y)
//{
//    if (x > y) return x;
//    else if (x < y) return y;
//    return x;
//}


// # 10.5

//Console.Write("Введите a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine(sign(a) + sign(b));
//int sign(double a)
//{
//    if (a < 0) return -1;
//    else if (a > 0) return 1;
//    return 0;
//}


// # 10.6

//Console.Write("Введите a: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите d: ");
//double d = double.Parse(Console.ReadLine());
//double c = gip(a, b);
//double e = gip(c, d);
//Console.WriteLine($"P = {a + b + d + e:F2}");
//double gip(double x, double y)
//{
//    return Math.Sqrt(x * x + y * y);
//}


// # 10.15

//for (int i = 100; i < 1000; i++)
//{
//	if (isSimple(i) == true) Console.Write(i + " ");
//}
//bool isSimple(int x)
//{
//    int k = 0;// делители
//	for (int i = 2; i < x; i++)
//	{
//		if (x % i == 0) k++;
//	}
//	if (k == 0) return true;
//	return false;
//}


// # 10.17

//long Fact (int x)
//{
//    long f = 1;
//    for (int i = 1; i <= x; i++) f *= i;
//    return f;
//}
//double y = (2.0 * Fact(5) + 3 * Fact(8)) / (Fact(6) + Fact(4));
//Console.WriteLine(y.ToString("F2"));


// # 10.33

//void Draw ()
//{
//    for (int i = 0; i < 80; i++)
//    {
//        Console.Write("*");
//    }
//}
//Draw();


// # 10.34 и 10.35 скопируй с гита

//void Draw()
//{
//    for (int i = 0; i < Console.WindowWidth; i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//    for (int i = 0; i < Console.WindowWidth; i++)
//    {
//        if (i == 0 || i == Console.WindowWidth - 1) Console.Write("*");
//        else Console.Write(" ");
//    }
//}
//Draw();


// ПРАКТИКА


// # 2

//double Avg(int[] mas)
//{
//    double s = 0;
//    foreach (var item in mas) s += item;
//    return s / mas.Length;
//}
//Random random = new Random();
//int[] mas = new int[random.Next(10, 20)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(Avg(mas).ToString("F2"));


// # 3 git

// # 5 git что-то изменил в нормальном коде


//void Swap (int a, int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//int x = 7, y = 9;
//Console.WriteLine(x + " " + y);
//Swap (x, y);
//Console.WriteLine(x + " " + y);// не меняет

//void Swap(ref int a, ref int b)// ref - передача по ссылке
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//int x = 7, y = 9;
//Console.WriteLine(x + " " + y);
//Swap(ref x, ref y);
//Console.WriteLine(x + " " + y);// меняет


int func (in int x)// x нельзя изменить - входной параметр (нужно для безопасности)
{
    return 2 * x + 1;
}

int x = 1;
int y = 2;
int s = 0;

void Add (int x, int y, out int s) 
{
    s = x + y;
}
Add(x, y, out s);
Console.WriteLine(s);

int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine(n);
