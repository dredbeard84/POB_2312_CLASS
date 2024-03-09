// Тема 15 (4)

/* Создать 4 массива.
   Заполнить их случайными числами.
   Конечным результатом должен быть, выведенный на консоль, массив, хранящий следующее:
   Произведение средних арифметических (1 и 2) и (3 и 4) массивов поиндексно. */

int[] mas1 = new int[2];
int[] mas2 = new int[2];
//int[] mas3 = new int[2];
//int[] mas4 = new int[2];
Random random = new Random();
Console.WriteLine("Массив 1: ");
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10, 100);
    Console.Write(mas1[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Массив 2: ");
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(10, 100);
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
double[] mas = new double[2];
Console.WriteLine("Среднее арифметическое 1 и 2 массивов поиндексно: ");
for (int i = 0; i < mas1.Length; i++)
{
    mas[i] = (mas1[i] + mas2[i]) / 2;
    Console.Write(mas[i] + " ");
}

//Console.Write("Массив 3: ");
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = random.Next(10, 100);
//    Console.Write(mas3[i] + " ");
//}
//Console.WriteLine();
//Console.Write("Массив 4: ");
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10, 100);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();