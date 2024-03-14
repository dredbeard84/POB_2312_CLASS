// Тема 18

// ПРАКТИКА 18

// # 1

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите слово: ");
//string word = Console.ReadLine();
//string result = "Результат: ";
//if (text.Contains(word)) result += "строка содержит указанное слово.";
//else result += "строка не содержит указанное слово.";
//Console.WriteLine(result);


// # 2

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите символ для замены: ");
//char s = char.Parse(Console.ReadLine());
//Console.Write("Введите символ, на который нужно заменить: ");
//char c = char.Parse(Console.ReadLine());
//text = text.Replace(s, c);// замена S на С
//Console.WriteLine(text);


// # 3

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите слово для подсчёта: ");
//string word = Console.ReadLine();
//string[] mas = text.Split(" ");
//// 1 вариант
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(word)) count++;
//}
//Console.WriteLine("Количество вхождение: " + count);
//// 2 вариант
//count = 0;
//int index = 0;
//while (text.IndexOf(word, index) != -1)
//{
//        count++;
//        index = text.IndexOf(word, index) + word.Length;
//}
//Console.WriteLine("Количество вхождение: " + count);


// # 4*

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите слово для замены: ");
//string word = Console.ReadLine();
//string replace = " ";
//foreach (var item in word) replace += "*";
//text = text.Replace(word, replace);
//Console.WriteLine(text);


// ПРАКТИКА 18_2

// # 4

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//string[] mas = text.Split(' ');
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(',')) Console.WriteLine(double.Parse(mas[i]).GetType());
//    else Console.WriteLine(int.Parse(mas[i]).GetType());
//}


// # 5

