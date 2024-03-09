// Урок 9

//int a = 30;
//a /= 5;
//Console.WriteLine(a);

//// 1. Побитовое умножение (только числа, а не булевые данные)
//// a) 9 * 6 = 0
//// b) 16 * 7 = 0
//// c) 8 * 14 = 8
//// d) 5 * 22 = 4
//int a = 5;
//int b = 22;
//int c = a & b;
//Console.WriteLine(c);


//// 2. Побитовое сложение
//// a) 5 | 9 = 13
//// b) 8 | 19 = 27
//// c) 3 | 7 = 7
//// d) 22 | 46 = 62
//int a = 22;
//int b = 46;
//int c = a | b;
//Console.WriteLine(c);


//// 3. Логическое исключение
//// a. 9 ^ 6 = 15
//// b. 498 ^ 244 = 262
//// c. 294862 ^ 198746 = 
//int a = 294862;
//int b = 198746;
//int c = a ^ b;
//Console.WriteLine(c);


//// 5. Сдвиг вправо и влево (например, на 2)
//// a. 894 257
//// b. 2 364 9587
//int a = 894257;
//// ?
//Console.WriteLine(a);


//int a = 10;
//int b = 5;
//if (a < b)// ; - не нужно
//{
//    Console.WriteLine(a);
//    Console.WriteLine(b);
//}
//else
//{
//    Console.WriteLine(a);
//    Console.WriteLine(b);
//}


Console.Write("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;
if ((a%2) == 1)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число чётное");
}
