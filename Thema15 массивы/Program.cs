// Тема 15: Одномерные массивы

//          создание массива

//          1 способ - инициализация

//int[] mas1 = new int[] { 4, 7, 3, 8, 2 };


//          2 способ - ввод с клавиатуры

//int[] mas2 = new int[5];// массив заполнен нулями
//Console.WriteLine("Введите элементы массива:");
//for (int i = 0; i < mas2.Length; i++)// ввод элементов массива
//{
//    mas2[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < mas2.Length; i++)// вывод элементов массива
//Console.Write(mas2[i]+" ");
//Console.WriteLine();// разделитель


//          3 - по формуле

//int[] mas3 = new int[10];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i * 1;
//    Console.Write(mas3[i] + " ");
//}
//Console.WriteLine();


//          4 - генерация случайных чисел

//int[] mas4 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10, 100);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();

//double[] mas5 = new double[20];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = random.NextDouble() * 100;
//    Console.Write($"{mas5[i]:F2} ");
//}
//Console.WriteLine();


//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
///*            int i = 0 начало массива
//              i < mas.Length конец массива
//              i++ счётчик */
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//    sum += mas[i];
//}
//// вывод
//foreach (int i in mas)// i уже не индекс массива, а элемент
//{
//    Console.WriteLine(i + " ");
//}
//Console.WriteLine();
//Console.WriteLine("Sum = " + sum);


// задача 1 из презентации

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(-7, 8);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.Write("Введите число от -7 до 7: ");
//int n = int.Parse(Console.ReadLine());
//int last = -1;
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] == n) last = i;
//    if (mas[i] < n) count++;
//}
//if (last != -1) Console.WriteLine("Индекс последнего вхождения: " + last);
//else Console.WriteLine("Такого числа нет");
//Console.WriteLine($"Количество элементов меньше {n}: {count}");


// практикум

// # 1

//int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] mas2 = new int[10];
//int[] mas3 = 


// # 2

//string[] mas = { "Дмитрий", "Максим", "Сергей", "Андрей", "Владислав" };
//Console.WriteLine(mas[1]);
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.WriteLine(mas[i]);
//}

// # 3

//Console.WriteLine("Введите номер от 0 до 4: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(mas[n]);


// # 4

//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//string[] mas = new string[n];
//Console.WriteLine("Введите имена:");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas)
//{
//    Console.WriteLine(i + " ");
//}
//Console.WriteLine();


// # 5

//int[] mas = { 4, 7, 3, 9, 2, 5, 8 };
//Console.WriteLine("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//bool have = false;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] == n)
//    {
//        have = true;
//        break;
//    }
//}
//if (have == true) Console.WriteLine(n);
//else Console.WriteLine("Число не найдено");


// # 6

//int[] mas = new int[10];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//    if (mas[i] % 3 == 0) sum += mas[i];
//}
//Console.WriteLine();
//Console.WriteLine($"Sum = {sum}");


// # 7. Создайте массив из 20 случайных действительных чисел и найдите в нем индекс первого отрицательного элемента.

//double[] mas = new double[20];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100 - 50;// генерация отрицательных чисел
//    Console.Write($"{mas[i]:F2} ");
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] < 0)
//    {
//        int index = i;
//        Console.WriteLine("Индекс первого отрицательного числа: " + index);
//        break;
//    }
//}


// # 8. Создайте массив из 15 случайных целых чисел и выведите на экран только те элементы, которые делятся на 2 и не делятся на 3.

//int[] mas = new int[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//foreach (int i in mas)
//{
//    if (i % 2 == 0 && i % 3 != 0) Console.Write(i + " ");
//}


// # 9. Создайте массив из 12 случайных целых чисел и найдите в нем наибольший элемент, наименьший элемент и среднее арифметическое всех элементов.

//int[] mas = new int[12];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)// генерация элементов массива и вывод на экран
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int min = mas[0];
//int max = mas[0];
//double sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//    sum += mas[i];
//}
//Console.WriteLine("Max = " + max);
//Console.WriteLine("Min = " + min);
//Console.WriteLine($"Avg = {sum/mas.Length:F2}");


// # 10. Создайте массив из 8 строк и найдите в нем самую короткую и самую длинную строку, а также выведите на экран все строки, содержащие букву "а".

//string[] mas = new string[8];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    string temp = "";
//    for (int j = 0; j < random.Next(1, 30); j++)// длина строки random.Next()
//    {
//        temp += (char)random.Next(97, 123);
//    }
//    mas[i] = temp;
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int max = mas[0].Length;
//int min = mas[0].Length;
//string maxStr = mas[0];
//string minStr = mas[0];
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        maxStr = mas[i];
//    }
//    if (mas[i].Length < min)
//    {
//        min = mas[i].Length;
//        minStr = mas[i];
//    }
//    if (mas[i].Contains("a")) Console.WriteLine(mas[i] + " ");
//}
//Console.WriteLine("Max = " + maxStr);
//Console.WriteLine("Min = " + minStr);


// сортировка массива (пузырьком)

//Random random = new Random();
//int[] mas = new int[random.Next(21)];// длина массива от 0 до 20
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(1, 101);// содержимое массива
//    Console.Write(mas[i] + " ");
//}
//for (int i = 0; i < mas.Length - 1; i++)// алгоритм сортировки, проходит по опорным элементам
//{
//    for (int j = i + 1; j < mas.Length; j++)// сравнение со следующим элементом
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//Console.WriteLine();
//foreach (int i in mas)// вывод результата
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();


// # 11. Создайте массив из 30 случайных целых чисел и выведите на экран все элементы, которые встречаются в массиве больше одного раза.

//          создание основного массива

//int[] mas = new int[30];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(20);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//          сортировка массива

//Array.Sort(mas);

//          вывод отсортированного массива на экран

//foreach (int item in mas)
//{
//    Console.Write(item + " ");
//}

//int count = 0;
//int temp = -1;

//          создание вспомогательного массива для найденных чисел
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] == mas[i - 1]) count++;

//    else if (mas[i] != mas[i - 1])
//    {
//        if (count > 0)
//        {
//            Console.Write(mas[i-1] + " ");
//        }
//    }
//}
// дописать



// СВОЙСТВА И МЕТОДЫ ОДНОМЕРНЫХ МАССИВОВ


//int[] mas = new int[5];
//Console.WriteLine($"Длина массива: {mas.Length}");
//Console.WriteLine($"Размерность массива: {mas.Rank}");

//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//// метод GetValue
//Console.WriteLine($"Значение 2-го элемента  {mas[2]}");
//Console.WriteLine(mas.GetValue(2));
//Console.WriteLine();

//// метод SetValue
//mas[3] = 6;
//mas.SetValue(6, 3);
//Console.WriteLine(mas[3]);
//Console.WriteLine();

//// метод Copy
//int[] mas2 = { 3, 6, 1, 7, 2, 8 };
//int[] mas3 = new int[6];
//mas2.CopyTo(mas3, 0);// 0 - с какого индекса копировать, в данном случае полностью
//foreach (int i in mas3) Console.Write(i + " ");
//Console.WriteLine();

//// класс Array, метод Sort
//Array.Sort(mas3);
//foreach (int item in mas3) Console.Write(item + " ");
//Console.WriteLine();

//string[] strMas = { "qwerty", "lilo", "asdrtgd", "whoami" };
//Array.Sort(strMas);
//foreach (string i in strMas) Console.Write(i + " ");
//Console.WriteLine();

//// метод Reverse
//Array.Reverse(mas3);
//foreach (int item in mas3) Console.Write(item + " ");
//Console.WriteLine();

//// Index / BinarySearch (поиск в массиве)
//Console.WriteLine(Array.IndexOf(mas3, 2));// поиск первого вхождения элемента "2" с начала массива
//Console.WriteLine(Array.LastIndexOf(mas3, 2));// поиск с конца
//Console.WriteLine(Array.LastIndexOf(mas3, 5));// 5 в массиве не существует, результат: -1 (= false)
//Console.WriteLine(Array.BinarySearch(mas3, 7));// 
//Console.WriteLine();

//// Concat
//int[] sumMas = mas.Concat(mas2).ToArray();
//foreach (var i in sumMas) Console.Write(i + " ");
//Console.WriteLine();

//// Clear
//Array.Clear(sumMas);
//Console.WriteLine(sumMas.Length);
//foreach (var i in sumMas) Console.Write(i + " ");
//Console.WriteLine();

//// Resize
//Array.Resize(ref mas2, 8);// увеличение массива до 8 (= +2)
//foreach (var i in mas2) Console.Write(i + " ");
//Console.WriteLine();


// ПРАКТИКА 15 (3)

// # 1

//Random random = new Random();
//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.WriteLine("Сгенерированный массив");
//    Console.WriteLine($"{mas[i] }");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//foreach (var i in mas) Console.Write($"{i} ");
//Console.WriteLine();


// # 2

//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите " + (i + 1) + " слово: ");
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.WriteLine(i + " ");
//Console.WriteLine();
//int max = mas[0].Length;
//string res = mas[0];
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        res = mas[i];
//    }
//}
//Console.WriteLine(res);


// # 3

//Random random = new Random();

//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();

//int[] mas2 = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas2[i] = random.Next(10);
//    Console.Write($"{mas2[i]} ");
//}
//Console.WriteLine();

//int[] mas3 = mas.Concat(mas2).ToArray();
//double sum = 0;
//foreach (var i in mas3)
//{
//    sum += i;
//    Console.Write(i + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"Avg: {sum / mas3.Length:F2}");
////Console.WriteLine((sum/mas3.Length).ToString("F2"));


// # 4. Напишите программу, которая запрашивает у пользователя 10 чисел и сохраняет их в массиве. Затем программа находит и выводит на экран наименьшее и наибольшее число в массиве.

//Random random = new Random();
//int[] mas = new int[10];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//Console.WriteLine($"Max = {mas.Max()}");
//Console.WriteLine($"Min = {mas.Min()}");


// # 5. Напишите программу, которая запрашивает у пользователя 5 слов и сохраняет их в массиве. Затем программа выводит на экран все слова из массива, начинающиеся на определенную букву, которую вводит пользователь. Для данной задачи используйте метод “IndexOf()”

//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите " + (i + 1) + " слово: ");
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i + " ");
//Console.WriteLine();

//Console.Write("Введите символ: ");
//char c = char.Parse(Console.ReadLine());
//foreach (string i in mas)
//{
//    if (Array.IndexOf(i.ToArray(), c) == 0) Console.Write(i + " ");
//}


// ПРАКТИКА 15 (4)

// # 1

//Random random = new Random();

//string a = "Tom";
//string b = "Jerry";
//string c = "Bob";
//string d = "Mike";
//string e = "Stive";
//string f = "John";

//string[] names = new string[6];

//for (int i = 0; i < names.Length; i++)
//{
//    switch (random.Next(6))
//    {
//        case 0: names[i] = a; break;
//        case 1: names[i] = b; break;
//        case 2: names[i] = c; break;
//        case 3: names[i] = d; break;
//        case 4: names[i] = e; break;
//        case 5: names[i] = f; break;
//    }
//    Console.Write(names[i] + " ");
//}
//Console.WriteLine();

//do
//{
//    Console.Write("Введите имя: ");
//    string name = Console.ReadLine();
//    while (Array.IndexOf(names, name) != -1)
//    {
//        names[Array.IndexOf(names, name)] = "Удалён";

//    }
//    Console.Write("Продолжить? ");
//    char answer = char.Parse(Console.ReadLine());
//    if (answer == 'n') break;
//}
//while (true);
//foreach (string i in names)
//    if (i != "Удалён") Console.Write(i + " ");


/* # 2. Создать 2 массива, создать цикл, заполняющий их случайными числами.
        Создать 3й массив, заполняемый разностями чисел 1го и 2го массива. */

//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//Random random = new Random();
//int[] mas1 = new int[n];
//int[] mas2 = new int[n];
//int[] mas3 = new int[n];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10, 100);
//    mas2[i] = random.Next(10, 100);
//    mas3[i] = mas1[i] - mas2[i];
//    Console.WriteLine($"{mas3[i]}\t {mas1[i]}\t {mas2[i]}");
//}


/* # 3. Создать массив объектов, вывести его значения в обратном порядке и соединить их в строку, в которой, впоследствии, методом Substring() срезать половину символов (подсчитанных программно). */

//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());

//Random random = new Random();
//double[] mas = new double[n];
//Console.WriteLine("Массив (прямой):");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//string strMas = "";
//Console.WriteLine("Массив (обратный):");
//foreach (double i in mas)
//{
//    Console.Write($"{i:F2} ");
//    strMas += i.ToString("F2") + " ";
//}
//Console.WriteLine();
//Console.WriteLine("Массив (обратный) - строка:");
//Console.WriteLine(strMas);
//Console.WriteLine("Массив (обратный) - строка, урезанный вдвое:");
//Console.WriteLine(strMas.Substring(0, strMas.Length / 2 - 1));


/* # 4. Создать 3 массива, заполнить их случайными числами.
        Создать 4й, пустой массив, куда поместить средние арифметические каждого индекса, каждого массива. */

// решили не делать
