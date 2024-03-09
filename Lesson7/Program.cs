////          Урок 7.1
//// Console - класс
//// ReadLine()


//// WriteLine() - метод ввода и вывода

//// Вывод числа в консоль
//Console.WriteLine(5);

//// Вывод строки в консоль
//Console.WriteLine("Привет");

//int result = 2 + 2;
//////Console.WriteLine(result);
////Console.WriteLine(result.ToString);
//Console.WriteLine(int.Parse(result.ToString()));

//Console.ReadLine();

//Console.WriteLine("Введите 2 числа: ");
//int a = int.Parse(Console.ReadLine());// лучше не "a", а "first"
//int b = int.Parse(Console.ReadLine());// лучше не "b", а "second"
//int c = a + b;// лучше не "c", а "result"
////Console.WriteLine(c);
//Console.WriteLine($"{a}+{b}");


//// Ввод/вывод строковых данных
//Console.WriteLine("Укажите имя: ");
//string name = Console.ReadLine();

//Console.WriteLine("Укажите фамилию: ");
//string surName = Console.ReadLine();

//Console.WriteLine("Укажите возраст: ");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine(age);

//////string result = "name" + "surName" + "age";// конкатенация = namesurnameage
////string result = $"{name} {surName} {age}";// интерполяция
//string result = $"{name}\n{surName}\n{age}";// управляющая последовательность \n - с новой строки
//Console.WriteLine(result);


// Даты
//// создание конкретной даты
//Console.WriteLine("20.01.2024");
//DateTime date = new DateTime(2024, 01, 20);
//Console.WriteLine(date);

//// создание текущей даты
//DateTime currentDate = DateTime.Now;
//Console.WriteLine($"Текущая дата: {currentDate}");


//          Урок 2

//// практика 1

//Console.WriteLine("Введите имя: ");
//string name = Console.ReadLine();

//Console.WriteLine("Введите фамилию: ");
//string surName = Console.ReadLine();

//Console.WriteLine("Введите отчество: ");
//string fatherName = Console.ReadLine();

//Console.WriteLine("Введите дату рождения: ");
//string birthDate = Console.ReadLine();

//Console.WriteLine("Укажите адрес: ");
//string address = Console.ReadLine();

//Console.WriteLine("Укажите должность: ");
//string profession = Console.ReadLine();

//Console.WriteLine("Укажите место работы: ");
//string work = Console.ReadLine();

//Console.WriteLine("Укажите номер телефона: ");
//string numberOfPhone = Console.ReadLine();

//Console.WriteLine("Укажите семейное положение: ");
//string familyStatus = Console.ReadLine();

//Console.WriteLine("Укажите номер банковского счёта:");
//string bankNumber = Console.ReadLine();

//string result = $"Пользователь:\n{name}\n{surName}\n{fatherName}\n{birthDate}\n{address}\n{profession}\n{work}\n{numberOfPhone}\n{familyStatus}\n{bankNumber}";
//Console.WriteLine(result);



// практика 2

// 1-й продукт
Console.Write("Укажите 1-й продукт: ");
string firstProductName = Console.ReadLine();
Console.Write($"Укажите цену за {firstProductName}: ");
decimal firstProductPrice = decimal.Parse(Console.ReadLine());
Console.Write($"Укажите количество продукта {firstProductName}, по цене {firstProductPrice}: ");
int firstProductQuantity = int.Parse(Console.ReadLine());
decimal totalFirstProduct = firstProductPrice * firstProductQuantity;
Console.Write($"Полная стоимость: {totalFirstProduct}");
Console.WriteLine("\n");

//// 2-й продукт
//Console.Write("Укажите 2-й продукт: ");
//string secondProductName = Console.ReadLine();
//Console.Write($"Укажите цену за {secondProductName}: ");
//decimal secondProductPrice = decimal.Parse(Console.ReadLine());
//Console.Write($"Укажите количество продукта {secondProductName}, по цене {secondProductPrice}: ");
//int secondProductQuantity = int.Parse(Console.ReadLine());
//decimal totalSecondProduct = secondProductPrice * secondProductQuantity;
//Console.WriteLine($"Всего {totalSecondProduct} руб.");
//Console.WriteLine("\n");

//// 3-й продукт
//Console.Write("Укажите 3-й продукт: ");
//string thirdProductName = Console.ReadLine();
//Console.Write($"Укажите цену за {thirdProductName}: ");
//decimal thirdProductPrice = decimal.Parse(Console.ReadLine());
//Console.Write($"Укажите количество продукта {thirdProductName}, по цене {thirdProductPrice}: ");
//int thirdProductQuantity = int.Parse(Console.ReadLine());
//decimal totalThirdProduct = thirdProductPrice * thirdProductQuantity;
//Console.WriteLine($"Всего {totalThirdProduct} руб.");
//Console.WriteLine("\n");

// 4 - й продукт
Console.Write("Укажите 4-й продукт: ");
string fourthProductName = Console.ReadLine();
Console.Write($"Укажите цену за {fourthProductName}: ");
decimal fourthProductPrice = decimal.Parse(Console.ReadLine());
Console.Write($"Укажите количество продукта {fourthProductName}, по цене {fourthProductPrice}: ");
int fourthProductQuantity = int.Parse(Console.ReadLine());
decimal totalFourthProduct = fourthProductPrice * fourthProductQuantity;
Console.WriteLine($"Всего {totalFourthProduct} руб.");
Console.WriteLine("\n");

// чек
Console.WriteLine("\tООО \"Название магазина\"");
Console.WriteLine("\n");
Console.WriteLine("Товар\tЦена\tКоличество\tСумма\n");
Console.WriteLine($"{firstProductName}\t{firstProductPrice}\t{firstProductQuantity}\t\t{totalFirstProduct}\n");
Console.WriteLine($"{secondProductName}\t{secondProductPrice}\t{secondProductQuantity}\t\t{totalSecondProduct}\n");
Console.WriteLine($"{thirdProductName}\t{thirdProductPrice}\t{thirdProductQuantity}\t\t{totalThirdProduct}\n");
Console.WriteLine($"{fourthProductName}\t{fourthProductPrice}\t{fourthProductQuantity}\t\t{totalFourthProduct}\n");
decimal totalPrice = totalFirstProduct + totalSecondProduct + totalThirdProduct + totalFourthProduct;
Console.WriteLine($"\t\t\tСумма: {totalPrice}\a");
