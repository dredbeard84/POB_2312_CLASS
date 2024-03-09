// Тема 14: Циклы: for


// # 1 (из презентации)

//for (int i = 35; i <= 87; i++)
//{
//    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) Console.Write(i + " ");
//}
//Console.WriteLine();// 36 37 40 43 44 47 50 51 54 57 58 61 64 65 68 71 72 75 78 79 82 85 86

// если использовать while
//int j = 35;
//while (j <= 87)
//{
//    if (j % 7 == 1 || j % 7 == 2 || j % 7 == 5) Console.Write(j + " ");
//    j++;
//}
//Console.WriteLine();// 36 37 40 43 44 47 50 51 54 57 58 61 64 65 68 71 72 75 78 79 82 85 86


// # 2 (из презентации)

//Console.Write("Введите n: ");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= n; sum += i, i++) ;
//Console.WriteLine(sum);


// ПРАКТИКА 14 (1)

// # 1. Напишите программу, которая запрашивает у пользователя строку-слово и выводит его в обратном порядке.

//Console.Write("Введите слово: ");
//string str = Console.ReadLine();
//for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);// int i = str.Length - 1   - обращение к последнему символу


/* # 2. Напишите программу, где от пользователя берётся на ввод строка-слово и производится проверка - является ли слово палиндромом или нет.
        С выводом пользователю результата. */

//Console.Write("Введите слово: ");
//string str = Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--) rts += str[i];
//if (str == rts) Console.Write("Палиндром");
//else Console.WriteLine("Не палиндром");
