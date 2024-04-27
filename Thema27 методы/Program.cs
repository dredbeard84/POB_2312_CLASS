// Урок 33. Методы

//Person person1 = new Person();
//class Person
//{
//    string FIO;
//    int age;
//    double rost;
//    double weight;
//}


// ПРАКТИКА

// # 1.1 калькулятор

//double x, y;
//Console.Write("Введите х: ");
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите y: ");
//double.TryParse(Console.ReadLine(), out y);
//Calculator calc = new Calculator(x, y);
//Console.WriteLine(calc.Add());
//Console.WriteLine(calc.Sub());
//Console.WriteLine(calc.Mult());
//Console.WriteLine(calc.Div());
//class Calculator
//{
//    private double X;
//    private double Y;
//    public Calculator(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//    public double Add() => X + Y;// лямбда-выражение => заменяет return
//    public double Sub()
//        { return X - Y; }// предложила автозамена
//    public double Mult()
//        {
//            return X * Y;
//        }
//    public double Div()
//        {
//            return X / Y;
//        }
//}


// # 1.2 строковый анализатор

//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//StringAnalizer analiz = new StringAnalizer(str);
//Console.WriteLine(analiz.getLength());
//Console.Write("Введите подстроку:");
//string sub = Console.ReadLine();
//Console.WriteLine(analiz.SubStr(sub));
//Console.WriteLine(analiz.OurToLower());
//Console.WriteLine(analiz.OurToUpper());
//class StringAnalizer
//{
//    private string Stroka;
//    public StringAnalizer(string stroka)
//    {
//        Stroka = stroka;
//    }
//    public int getLength()
//    {
//        return Stroka.Length;
//    }
//    public bool SubStr(string substr)
//    {
//        return Stroka.Contains(substr);
//    }
//    public string OurToUpper()
//    {
//        return Stroka.ToUpper();
//    }
//    public string OurToLower()
//    {
//        return Stroka.ToLower();
//    }
//}


// урок 34


/* # 2.1 Создайте класс "Массивы", содержащий методы для работы с массивами, такие как нахождение суммы элементов, нахождение минимального/максимального значения, сортировка массива и т.д.
  Напишите код, который использует эти методы для обработки заданных массивов. */

//Random random = new Random();
//int[] mas = new int[random.Next(1, 20)];
//mas = mas.Select(i => i + random.Next(1, 20)).ToArray();// альтернативный способ вывода масива через linq, а не через цикл
//Arrays arrays = new Arrays(mas);
//arrays.Print();
//Console.WriteLine("min = " + arrays.Min());
//Console.WriteLine("max = " + arrays.Max());
//arrays.Sort();
//arrays.Print();
//Console.WriteLine("sum = " + arrays.Sum());
//class Arrays
//{
//    private int[] mas;
//    public Arrays(int[] mas)
//    {
//        this.mas = mas;
//    }
//    public int Sum()
//    {
//        return mas.Sum();// linq (забежали немного вперёд)
//    }
//    public int Max()
//    {
//        //int max = mas[0];
//        //for (int i = 1; i < mas.Length; i++)
//        //    if (mas[i] > max) max = mas[i];
//        //return max;
//        return mas.Max();
//    }
//    public int Min()
//    {
//        return mas.Min();
//    }
//    public void Sort()
//    {
//        Array.Sort(mas);
//    }
//    public void Print()
//    {
//        foreach (int item in mas) Console.Write(item + " ");
//        Console.WriteLine();
//    }
//}


/* # 2.2 файловый менеджер */

//class FileManager
//{
//    private string fileName;
//    public FileManager(string f)
//    {
//        fileName = f;
//    }
//    public bool 
//}

// оставшийся код на гите


// # 3.1 генератор случайных чисел

//RandomClass rc = new RandomClass();
//Console.WriteLine(rc.RandomInt(100));
//Console.WriteLine($"{rc.RandomDouble(200):F2}");
//Console.WriteLine(rc.RandomBool());
//class RandomClass
//{
//    private Random random;
//    public RandomClass()
//    { random = new Random(); }
//    public int RandomInt(int n) => random.Next(n);
//    public double RandomDouble(int n) => random.NextDouble() * n;
//    public bool RandomBool() => (random.Next(0, 2) == 0) ? false : true;
//}


// проверка на null - на Metanit (гл. 3)


// # 3.2 

//Console.Write("Введите строку: ");
//MyString myString = new MyString(Console.ReadLine()!);
//Console.WriteLine(myString.Reverse());
//Console.WriteLine(myString.IsPolindrom() ? "Полиндром" : "Не полиндром");
//Console.Write("Введите символ: ");
//char c = char.Parse(Console.ReadLine()!);
//foreach (var item in myString.Split(c))
//{ Console.WriteLine(item); }
//Console.Write("Введите индекс: ");
//int index = int.Parse(Console.ReadLine()!);
//foreach (var item in myString.Split(index))
//{ Console.WriteLine(item); }
//Console.Write("Введите строку для поиска: ");
//string findStr = Console.ReadLine()!;
//Console.WriteLine(myString.Find(findStr) ? "Есть" : "Нет");
//class MyString
//{
//    private string str;// объявление переменной
//    public MyString(string str)// инициализация переменной
//    {
//        this.str = str;
//    }
//    public string Reverse()
//    {
//        string res = "";
//        for (int i = str.Length - 1; i >= 0; i--) res += str[i];
//        return res; 
//    }
//    public bool IsPolindrom() => (Reverse() == str) ? true : false;
//    public string[] Split(char c) => str.Split(c);
//    public string[] Split(string c) => str.Split(c);
//    public string ToUpper() => str.ToUpper();
//    public string ToLower() => str.ToLower();
//    public string[] Split(int index)
//    {
//        if (index > 0 && index <= str.Length - 1)
//        {
//            char c = str[index];
//            return str.Split(c);
//        }
//        else throw new Exception("Выход за границы строки");
//    }
//    public bool Find(string word) => str.Contains(word);
//}


// # 4.1

