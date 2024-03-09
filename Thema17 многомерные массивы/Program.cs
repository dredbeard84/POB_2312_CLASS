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


// ПРАКТИКА

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

Random random = new Random();
string[] mast = new string[] { "пики", "крести", "черви", "буби" };
string[] nominal = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "валет", "дама", "король", "туз" };
string[,,] players = new string[4, 1, 1];
for (int i = 0; i < players.GetLength(0); i++)
{
	for (int j = 0; j < players.GetLength(1); j++)
	{
		for (int k = 0; k < players.GetLength(2); k++)
		{
			players[i, j, 0] = mast[random.Next(4)];
			players[i, j, 1] = nominal[random.Next(13)];
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}
