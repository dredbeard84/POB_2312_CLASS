// Тема 16: Двумерные массивы


// type[,] name = new type [n, m];


//Console.Write("Введите число строк: ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите число столбцов: ");
//int m = int.Parse(Console.ReadLine());
//int[,] mas = new int[n, m];// объявление массива
//Random random = new Random();
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)// размерность 0 - количество строк
//{
//	for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)// размерность 1 - кол-во столбцов
//	{
//		mas[i,j] = random.Next(10, 100);
//		Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}


// другой способ формирования массива
//int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// вариант записи
//int[,] mas2 = { { 1, 2, 3 },
//				{ 4, 5, 6 },
//				{ 7, 8, 9 } };
//for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
//{
//	for (int j = 0; j < mas2.GetUpperBound(1) + 1; j++)
//	{
//		Console.Write(mas2[i, j] + " ");
//	}
//	Console.WriteLine();
//}


// ПРАКТИКА 16 (1)


// # 1. Написать программу для нахождения суммы элементов двумерного массива.

//Random random = new Random();
//int n = random.Next(1, 10);// кол-во строк
//int m = random.Next(1, 10);// кол-во столбцов
//int[,] mas = new int[n, m];
//int sum = 0;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//	for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//	{
//		mas[i, j] = random.Next(10, 100);
//		sum += mas[i, j];
//        Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine($"Sum = {sum}");


// # 2. Написать программу для нахождения произведения элементов двумерного массива.

//Random random = new Random();
//int n = random.Next(1, 10);// кол-во строк
//int m = random.Next(1, 10);// кол-во столбцов
//int[,] mas = new int[n, m];
//double P = 1;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//	for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//	{
//		mas[i, j] = random.Next(10, 100);
//		P *= mas[i, j];
//		Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine($"Произведение = {P:F2}");


// # 3. Написать программу, выводящую элементы двумерного массива по диагонали.

//Random random = new Random();
//int n = random.Next(5, 10);
//int m = random.Next(5, 10);
//int[,] mas = new int[n, m];
//int count = 0;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//	for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//	{
//		mas[i, j] = random.Next(10, 100);
//		for (int k = 0; k < count; k++) Console.Write(" ");
//		Console.WriteLine(mas[i, j] + " ");
//		count++;
//	}
//}


/* # 4. Написать программу — телефонный справочник — создать двумерный массив 5*3, хранящий список телефонных контактов:
        первый элемент хранит имя контакта,
        второй — номер,
        третий e-mail
    2.1 Вывести все элементы массива на экран.
    2.2 Вывести три элемента: имя, номер и e-mail по запросу пользователя по имени. */


//string[,] mas = { { "Tom", "11-22-33", "tom@mail.com" },
//                  { "Jerry", "44-55-66", "jerry@mail.com" },
//                  { "Bob", "77-88-99", "bob@mail.com" } };
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.Write("Введите имя: ");
//string name = Console.ReadLine();
//bool isTrue = false;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    if (mas[i, 0] == name) Console.WriteLine(mas[i, 0] + " " + mas[i, 1] + " " + mas[i, 2]);
//}
//Console.WriteLine();
//if (isTrue == false) Console.WriteLine("Такого имени нет");


// ПРАКТИКА 16 (2)

// # 2. Написать программу для нахождения среднего значения каждой строки двумерного массива.

//Random random = new Random();
//int n = random.Next(1, 10);
//int m = random.Next(1, 10);
//int[,] mas = new int[n, m];
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    double sum = 0;
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        sum += mas[i, j];
//    }
//    Console.WriteLine($"AVG {i + 1} = {sum/ mas.GetUpperBound(1) + 1:F2}");
//}


/* # 3. Написать программу для транспонирования двумерного массива (перевода строк в столбцы и наоборот).
        Подсказка: вам понадобится 2 массива. */

//Random random = new Random();
//int n = random.Next(5, 10);
//int m = random.Next(5, 10);
//int[,] mas1 = new int[n, m];
//int[,] mas2 = new int[m, n];
//for (int i = 0; i < mas1.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas1.GetUpperBound(1) + 1; j++)
//    {
//        mas1[i, j] = random.Next(10, 100);
//        Console.Write(mas1[i, j] + " ");
//        mas2[j, i] = mas1[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas2.GetUpperBound(1) + 1; j++)
//    {
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();


// # 4. лампочка (вариант преподавателя, в домашке - мой)

//string[,] mas ={
//    {"","","x","x","",""},
//    {"","x","","","x",""},
//    {"x","","","","","x"},
//    {"","x","x","x","x",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","x","x","x","x",""}};
//string answer = "no";
//bool isChecked = false;
//do
//{
//    Console.Clear();
//    for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//    {
//        for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//        {
//            if (mas[i, j] != null)
//            {
//                Console.Write($"{mas[i, j],2}");
//            }
//        }
//        Console.WriteLine();
//    }
//    if (isChecked == false) Console.Write("Включить лампочку?");
//    else Console.Write("Выключить лампочку?");
//    answer = Console.ReadLine()!;
//    if (answer == "yes") isChecked = !isChecked;
//    if (isChecked)
//    {
//        mas[1, 2] = "x"; mas[1, 3] = "x";
//        mas[2, 2] = "x"; mas[2, 3] = "x";
//        mas[2, 1] = "x"; mas[2, 4] = "x";
//    }
//    else
//    {
//        mas[1, 2] = ""; mas[1, 3] = "";
//        mas[2, 2] = ""; mas[2, 3] = "";
//        mas[2, 1] = ""; mas[2, 4] = "";
//    }
//}
//while (true);


// ЗАДАЧНИК

// # 12.22 таблица умножения

//int[,] mas = new int[9, 9];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = (i + 1) * (j + 1);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}


// # 12.23

//int[,] mas = new int[7, 7];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		if (i == j || i + j == mas.GetLength(0) - 1) mas[i, j] = 1;// а
//		if (i == mas.GetLength(0) / 2) mas[i, j] = 1;// б - горизонталь
//		if (j == mas.GetLength(1) / 2) mas[i, j] = 1;// б - вертикаль
//		Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}

// песочные часы

//int[,] mas = new int[7, 7];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (i == j || i + j == mas.GetLength(0) - 1) mas[i, j] = 1;
//        if (i > j && i + j > mas.GetLength(1) - 1) mas[i, j] = 1;
//        if (i < j && i + j < mas.GetLength(1) - 1) mas[i, j] = 1;
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
