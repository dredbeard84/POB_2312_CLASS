// Урок 24

// Тема 20: локальные функции

// ЗАДАЧНИК


// # 10.1 (a)

//double x = (Math.Sqrt(6) + 6) / 2 + 
//           (Math.Sqrt(13) + 13) / 2 + 
//           (Math.Sqrt(21) + 21) / 2;
//Console.WriteLine($"{x:F2}");

//x = Func(6) + Func(13) + Func(21);// фактический параметр

//double Func(int y)// формальный параметр
//{
//    return (Math.Sqrt(y) + y) / 2;
//}


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

//long Fact(int x)
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


//int func (in int x)// x нельзя изменить - входной параметр (нужно для безопасности)
//{
//    return 2 * x + 1;
//}
//int x = 1;
//int y = 2;
//int s = 0;
//void Add (int x, int y, out int s) 
//{
//    s = x + y;
//}
//Add(x, y, out s);
//Console.WriteLine(s);
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine(n);


// урок 25


// Практика 2


/* # 1. Создайте функцию, которая принимает строку и возвращает количество слов в этой строке.
        Напишите программу, которая использует эту функцию для подсчета количества слов во введённом пользователем предложении. 
*/

//int CountWords(string text)
//{
//    string[] mas = text.Split(' ');
//    return mas.Length;
//}
//Console.Write("Введите предложение: ");
//string str = Console.ReadLine();
//Console.WriteLine(CountWords(str));


/* # 2. Создайте функцию, которая принимает строку и возвращает количество слов в этой строке. 
        Напишите программу, которая использует эту функцию для подсчёта количества слов во введённом пользователем предложении. 
*/

//long Factorial(int x)
//{
//    long F = 1;
//    for (int i = 1; i <= x; i++) F *= i;
//    return F;
//}
//Console.Write("Введите число: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n}: {Factorial(n)}");


/* # 3. Создайте функцию, которая принимает двумерный массив целых чисел и выводит на экран его элементы в виде матрицы.
        Напишите программу, которая использует эту функцию для вывода элементов двумерного массива, заполненного пользователем. 
*/

//void PrintMatrix(int[,] mas)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//Random random = new Random();
//int[,] mas = new int[random.Next(5, 10), random.Next(5, 10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//    }
//}
//PrintMatrix(mas);


/* # 4.Создайте функцию, которая принимает массив строк и возвращает новый массив, содержащий только уникальные элементы.
       Напишите программу, которая использует эту функцию для удаления дубликатов из списка строк, заполненного пользователем. 
*/

//string[] UniqueWords(string[] text)
//{
//    string[] result = new string[text.Length];
//    int i = 0;
//    foreach (var item in text)
//    {
//        if (result.Contains(item)) result[i++] = item;
//    }
//    return result;
//}
//string[] mas = new string[6];
//Console.WriteLine("Введите слова: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//string[] res = UniqueWords(mas);
//foreach (string s in res) Console.Write(s + " ");
//Console.WriteLine();


/* # 5. Создайте функцию, которая принимает длину сторон треугольника и возвращает его площадь. 
        Напишите программу, которая использует эту функцию для вычисления площади треугольника с заданными сторонами, введенными пользователем. */

//double Square(double a, double b, double c)
//{
//    double pp = (a * b * c) / 2;
//    return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
//}
//double x, y, z;
//Console.Write("Введите a: ");
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out y);
//Console.Write("Введите c: ");
//double.TryParse(Console.ReadLine(), out z);
//Console.WriteLine($"Площадь: {Square(b: y, a: x, c: z):F2}");// именованные параметры


// params - необпределённое количество параметров (код на гите)


// Практика 3


/* # 1. Функция поиска слова.
        Напишите программу, в которой будет использоваться булевая функция, для поиска слова.
        В качестве параметров передаются 2 аргумента: текст и слово которое нужно найти.
        Если слово присутствует, функция вернёт true, в противном случае - false. */

//bool FindWord(string text, string word)
//{
//    return text.Contains(word);
//}
//Console.WriteLine("Введите текст: ");
//string myText = Console.ReadLine();
//Console.WriteLine("Введите слово: ");
//string wordFind = Console.ReadLine();
//Console.WriteLine(FindWord(myText, wordFind));


/* # 2. Обработка массива.
        Напишите программу, в которой будут присутствовать функции, обрабатывающие массивы.
        1-я будет возвращать тип массива, его максимальный элемент и сортировать его по возрастанию.
        2-я будет сращивать два массива в один.
        3-я будет переворачивать массив из предыдущей функции и выводить на экран его значение. */

//Random random = new Random();
//int[] mas1 = new int[random.Next(5, 10)];
//int[] mas2 = new int[random.Next(5, 10)];
//void FillArray(int[] mas)
//{
//    for (int i = 0; i < mas.Length; i++) mas[i] = random.Next(10, 100);
//}
//void Print(int[] mas)
//{
//    for (int i = 0; i < mas.Length; i++) Console.Write(mas[i] + " ");
//    Console.WriteLine();
//}
//FillArray(mas1);
//Print(mas1);
//FillArray(mas2);
//Print(mas2);
//string[] GetTypeAndMax(int[] mas)
//{
//    string[] result = new string[2];
//    result[0] = mas.GetType().ToString();
//    Array.Sort(mas);
//    result[1] = mas[mas.Length - 1].ToString();
//    return result;
//}
//Console.WriteLine($"Type = {GetTypeAndMax(mas1)[0]} " + $"Max = {GetTypeAndMax(mas1)[1]} ");
//Print(mas1);
//// продолжение на гите


/* # 3. Расчёты.
        Напишите череду функций, которые будут выполнять различные математические расчеты. */

//double getDiskriminant(double a, double b, double c)
//{
//    return b * b - 4 * a * c;
//}
//void Two

//double a, b, c;
//Console.WriteLine("Ввведите a: ");
//double.TryParse(Console.ReadLine(), out a);
//Console.WriteLine("Ввведите b: ");
//double.TryParse(Console.ReadLine(), out b);
//Console.WriteLine("Ввведите c: ");
//double.TryParse(Console.ReadLine(), out c);
