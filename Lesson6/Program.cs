//      Тема 6: Преобразование типов и способы


//byte number = 567;
/*      ошибка: 8 разрядов типа byte не достаточно, чтобы вместить данное число
 *      0010 0011 0111 - 12 разрядов
 *      ---- 0011 0111 -  8 разрядов в byte */


/*      ЯВНОЕ ПРЕОБРАЗОВАНИЕ (приведение):
 *      (type)value
 *       type - целевой тип данных
 *       value - исходная переменная, которую нужно конвертировать */

//short numberShort = 567;
//byte numberByte = (byte)numberShort;
//Console.WriteLine(numberByte);// 55
/*      потеря данных:
 *      0000 0010 0011 0111 - 567 в 16 разрядах short
 *      ---- ---- 0011 0111 - 55  в  8 разрядах byte */


//byte number = 200;
//char symbol = (char)number;
//Console.WriteLine(symbol);// E


//int numberOne =      new Random().NextDouble();// ошибка: генератор случайных чисел, выдаёт только вещественные числа
//int numberTwo = (int)new Random().NextDouble();// можно явно преобразовать в целые числа
//Console.WriteLine(numberTwo);


//double numberDouble = new Random().NextDouble() * 100000 + 30000;// число > short
//Console.WriteLine(numberDouble);
//Console.WriteLine((short)numberDouble);// преобразование в short может произойти с потерей данных


//      \n - литерал переноса на следующую строку
//string myPerson = "Ivan\nNepomiluev";
//Console.WriteLine(myPerson);


//      ПРЕОБРАЗОВАНИЕ СТРОК

//      1. класс Convert метод ToInt32

//string str = "123";
//int num = Convert.ToInt32(str);
//Console.WriteLine(num);

//      обратно методом ToString

//int num = 321;
//string str = Convert.ToString(num);
//Console.WriteLine(str);


//      2. Встроенные методы типов

//string myString = "248";                                  // инициализация переменной

//int number = int.Parse(myString);                         // число.Преобразуется(из строки)
//Console.WriteLine(number);                                // вывод числа на консоль
//Console.WriteLine(number.GetType());                      // получение типа данных

////Console.WriteLine(int.Parse(myString));                 // вариант вывода числа.Преобразованного(из строки)
////Console.WriteLine((int)myString);                       // ошибка: недопустимый способ явного преобразования (приведения)
////Console.WriteLine(number + " " + number.GetType());     // вариант вывода числа и его типа данных

//string newString = number.ToString();                     // число.ВСтроку
//Console.WriteLine(newString);                             // вывод новойСтроки
//Console.WriteLine(newString.GetType());                   // получение типа данных

////Console.WriteLine(myString + " " + myString.GetType()); // выриант вывода новойСтроки и её типа данных


//GetType - возвращает(показывает) тип данных .NET


/*      Задача 2.19
 *      Дано четырёхзначное число.
 *      Найти:
 *      а) сумму его цирф;
 *      б) произведение его цифр. */

//Console.Write("Введите число n: ");// n = 7631
//int n = int.Parse(Console.ReadLine());
//int a = n / 1000;// 7
//int b = n % 1000 / 100;// 6
//int c = n % 100 / 10;// 3
//int d = n % 10;// 1
//Console.WriteLine($"Сумма цифр: {a + b + c + d}");
//Console.WriteLine($"Произведение цифр: {a * b * c * d}");

/*      отладка:
 *      F10 - проверка построчно, 
 *      "видимые" - показывает результат */
