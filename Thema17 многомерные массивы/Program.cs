// Тема 17: Многомерные массивы
// Урок 20

// неровный массив (2D)

//Console.Write("Введите количество строк массива: ");
//int n = int.Parse(Console.ReadLine());
//int[][] mas  = new int[n][];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)// выделяем память под строки
//{
//    mas[i] = new int [random.Next(1,10)];
//}
//for (int i = 0; i < mas.Length; i++)// заполнение массива элементами
//{
//	for (int j = 0; j < mas[i].Length; j++)
//	{
//		mas[i][j] = random.Next(10, 100);
//		Console.Write(mas[i][j] + " ");
//	}
//	Console.WriteLine();
//}


// ПРАКТИКА 17_1

// # 1 шахматная доска

//char[,] mas = new char[8, 8];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		if ((i + j) % 2 == 0) mas[i, j] = 'W';
//		else mas[i, j] = 'B';
//		Console.Write(mas[i, j] + " ");
//	}
//	Console.WriteLine();
//}


// # 2 покер

//Random random = new Random();
//string[] mast = new string[] { "пики", "крести", "черви", "буби" };
//string[] nominal = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "валет", "дама", "король", "туз" };
//string[,,] players = new string[4, 2, 2];
//for (int i = 0; i < players.GetLength(0); i++)
//{
//	//Console.WriteLine(i + 1 + ". ");
//	for (int j = 0; j < players.GetLength(1); j++)
//	{
//		players[i, j, 0] = mast[random.Next(4)];
//		players[i, j, 1] = nominal[random.Next(13)];
//		Console.WriteLine((i + 1) + ". " + players[i, j, 0] + " " + players[i, j, 1] + " ");// \t в последних кавычках
//	}
//	Console.WriteLine();
//}


// ПРАКТИКА 17_2

// # 1


//int[,,] mas = new int[4, 6, 8];
//Random random = new Random();
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//	for (int i = 0; i < mas.GetLength(0); i++)
//	{
//		for (int j = 0; j < mas.GetLength(1); j++)
//		{
//			mas[i, j, k] = random.Next(10, 100);
//			Console.Write(mas[i, j, k] + " ");
//		}
//		Console.WriteLine();
//	}
//	Console.WriteLine();
//}
//Console.Write("Введите число: ");
//int m = int.Parse(Console.ReadLine());
//mas[3, 5, 7] = m;// добавление элемента в конец
//mas[0, 0, 0] = m;// добавление элемента в начало
//for (int k = 0; k < mas.GetLength(2); k++)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
// для удаления элемента, нужно заменить его на 0


// # 2

Random random = new Random();
int[,] mas1 = new int[3, 3];
int[,] mas2 = new int[3, 3];
for (int i = 0; i < mas1.GetLength(0); i++)
{
	for (int j = 0; j < mas1.GetLength(1); j++)
	{
		mas1[i, j] = random.Next(10, 100);
		Console.Write(mas1[i, j] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mas2.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i, j] = random.Next(10, 100);
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,,] mas = new int[3, 3, 2];
for (int k = 0; k < mas.GetLength(2); k++)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (k == 0) mas[i, j, k] = mas1[i, j];// I слой = I массив
            if (k == 1) mas[i, j, k] = mas2[i, j];// II слой = II массив
            Console.Write(mas[i, j, k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// dz 17-2 смотри в Git'e

