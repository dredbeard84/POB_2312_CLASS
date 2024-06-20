// Урок 13: Тема 13: Циклы

// Занятия 1 и 2: while и do/while


// while - цикл с предусловием


/* инициализация - присвоение пеерменной, учавствующей в цикле, начальных значений
   итерация - однократное выполнение тела цикла */


//int i = 5;// инициализация переменное
//while (i > 0)// while - пока
//{
//    Console.WriteLine(i);// тело цикла
//    --i;
//}
// или Console.WriteLine(i--);


/* n! - факториал 
  0! = 1
  1! = 1
  2! = 1 * 2 = 2
  3! = 1 * 2 * 3 = 6
  4! = 1 * 2 * 3 * 4 = 24
*/


// Вычислить n! (n вводится с клавиатуры)
//Console.Write("Введите число n: ");
//int n = int.Parse(Console.ReadLine());
//long Fact = 1;
//int i = 1;
//while (i < n)
//{
//    Fact *= i++;// то же что и Fact = Fact * 1 и i = i + 1
//}
//Console.WriteLine($"Факториал {n} = {Fact}");



//int a;
//double sum = 0;
//int CountGreat10 = 0;
//int CountLess10 = 0;
//double avg = 0;
//int min = int.MaxValue;
//int max = int.MinValue;
//int i = 1;
//while (i <= 10)
//{
//    Console.Write($"Введите {i} число: ");
//    a = int.Parse(Console.ReadLine());
//    sum += a;
//    if (a > 10) CountGreat10++;
//    if (a < 10) CountLess10++;
//    if (a > max) max = a;
//    if (a < min) min = a;
//    i++;
//}
//Console.WriteLine("Sum = " + sum);
//Console.WriteLine("Count > 10 = " + CountGreat10);
//Console.WriteLine("Count < 10 = " + CountLess10);
//Console.WriteLine("min = " + min);
//Console.WriteLine("max = " + max);
//Console.WriteLine($"avg = {sum/10}");



// do/while - цикл с постусловием


// найти сумму n целых положительных чисел

//int n;
//do
//{
//    Console.Write("Введите положительное число: ");
//    n = int.Parse(Console.ReadLine());
//    if (n <= 0) Console.WriteLine("Введите ПОЛОЖИТЕЛЬНОЕ число!");// можно убрать, чтобы не выводить 2 одинаковые строчки
//}
//while (n <= 0);
//int sum = 0;
//int i = 1;
//do
//{
//    sum += i++;
//}
//while (i <= n);
//Console.WriteLine("Sum = " + sum);



// операторы перехода: goto (не применяется), break, continue


//do
//{
//    int n;
//    do
//    {
//        Console.Write("Введите положительное число: ");
//        n = int.Parse(Console.ReadLine());
//        if (n <= 0) Console.WriteLine("Введите ПОЛОЖИТЕЛЬНОЕ число!");
//    }
//    while (n <= 0);
//    int sum = 0;
//    int i = 1;
//    do
//    {
//        sum += i++;
//    }
//    while (i <= n);
//    Console.WriteLine("Sum = " + sum);
//    Console.Write("Введите y/n для завершения: ");
//    char answer = char.Parse(Console.ReadLine());
//    if (answer == 'y') break;// 2. принудительно прекращает цикл
//}
//while (true);// 1. программа будет работать бесконечно


//int S = 0;
//int i = 1;
//Random random = new Random();
//while (i <= 50)
//{
//    int a = random.Next(1, 50);
//    if (a % 2 != 0) continue;// продолжение цикла при появлении чётного числа
//    Console.Write(a + " ");
//    S += a;
//    i++;
//}
//Console.WriteLine(S);



// практикум
// # 2

//int a;
//int b;
//do
//{
//    Console.WriteLine("Введите два разных числа: ");
//    a = int.Parse(Console.ReadLine());
//    b = int.Parse(Console.ReadLine());
//}
//while (a == b);
//if (a < b)
//{
//    int i = a;
//    while (i <= b)
//    {
//        Console.Write(i + " ");
//        i++;
//    }
//}
//else
//{
//    int i = a;
//    while (i >= b)
//    {
//        Console.Write(i + " ");
//        i--;
//    }
//}


// # 3

//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//while (i <= n)
//{
//    if (i % 2 != 0) Console.Write(i + " ");
//    i++;
//}


// # 4

//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine($"{n} * {i} = {n * i}");
//    i++;
//}


// #6

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());// объявление и инициализация переменной
//int i = 1;// счётчик
//while (i < n)// условие
//{
//    if (n % i == 0) Console.Write(i + " ");// тело цикла
//    i++;// инкремент
//}

// аналог с for
//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i < n; i++)// счётчик + условие + инкремент
//{
//    if (n % i == 0) Console.Write(i + " ");
//}


// #7 дописать

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//int k = 0;// количество делителей
//for (int i = 2; i < n; i++)
//{
//    if (n % i == 0) Console.Write(k++);
//    else Console.Write(k++);
//}


// #8

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//while (i <= n)
//{
//    int k = 0;// количество делителей
//    int j = 2;// второй счётчик
//    while (j < i)
//    {
//        if (i % j == 0) k++;
//        j++;
//    }
//    if (k == 0) Console.WriteLine(i + " ");
//    i++;
//}

// с for
//for (int i = 1; i <= n; i++)
//{
//    int k = 0;
//    for (int j = 2; j <= i; j++) if (i % j == 0) k++;
//    if (k == 0) Console.WriteLine(i + " ");
//}


// #9

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//string str = "";
//while (n != 1)
//{
//    int temp = n % 2;// можно убрать temp, заменив переменную формулой в следующей строке
//    str += temp;// неявное преобразование числа в строку и конкатенация строк
//    n /= 2;// это же счётчик
//}
//str += "1";// добавляем единицу в конце
//for (int i = str.Length - 1; i >= 0; i--)// разворачиваем в обратном порядке
//  Console.WriteLine(str[i]);

// for-edition
//for (; n != 1; str += n % 2, n /= 2);
//str += "1";
//for (int i = str.Length - 1; i >= 0; i--)
//    Console.Write(str[i]);


// практика 2

// #1

//Console.Write("Введите число n: ");
//int n = int.Parse(Console.ReadLine());
//long fact = 1;
//int i = 1;
//while (i <= n)
//{
//    fact *= i++;
//}
////for (int i = 1; i <= n; Fact *= i++);
//Console.WriteLine($"Факториал {n} = {fact}");


// #2

//Console.Write("Введите целое число A: ");
//int A = int.Parse(Console.ReadLine());
//Console.Write("Введите целое число B: ");
//int B = int.Parse(Console.ReadLine());
//for (int i = A; i <= B; i++)
//{
//    if (i % 3 == 0 || i % 5 == 0)
//        Console.Write(i + " ");
//}


// #3 фибоначчи (доработать)

//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//int i = 1;
//for (int j = 1; j <= n; j+=i)
//{
//    Console.WriteLine(j + " ");
//    i = j - i;
//}
