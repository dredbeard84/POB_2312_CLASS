//          Lesson 8

//          Унарные арифметические операции
//          Операто присваивания
//int x = 5; // действие выполняется справа, а результат присваивается влево

//          Операция инкремента: "++" - увеличение на 1 единицу
// а) x++ - постфиксная
// б) ++x - префиксная

//int x = 5;
//Console.WriteLine(x++);// 5 = 5 (сначала выводит х)
//Console.WriteLine(x);// 5 + 1 = 6 (затем увеличит на единицу след. переменную)

//Console.WriteLine(++x);// 5 + 1 = 6 (сразу увеличивает переменную на единицу)


//          Операция декремента: "--" - уменьшение на 1 единицу (пост- и префиксная)
//Console.WriteLine(--x); // 5 - 1 = 4

//Console.WriteLine(x--);// 5
//Console.WriteLine(x);// 5 - 1 = 4

//int x = 11;
//Console.WriteLine(x++*2);// 11 * 2 = 22
//Console.WriteLine(x);// 11 + 1 = 12

//Console.WriteLine(++x*2);// (11 + 1) * 2 = 24


//          ПРАКТИКА

//int x = 0;
//Console.WriteLine(x);// 0
//x = x + 46;
//Console.WriteLine(x);// 0 + 46 = 46
//x = x + 12;
//Console.WriteLine(x);// 46 + 12 = 58
//x = x + 4;
//Console.WriteLine(x);// 68 + 4 = 62
//x = x + 8;
//Console.WriteLine(x);// 72 + 8 = 70
//x = x + 15;
//Console.WriteLine(x);// 80 + 15 = 85


//int students = 28;
//int moms = 24;
//int dads = 18;
//int parentsA = dads - (students - moms);
//int parentsB = moms - (students - dads);
//Console.WriteLine(parentsA);// 14
//Console.WriteLine(parentsB);


//decimal all = 56000m;
//decimal part = all / 8;
//Console.WriteLine($"{part * 5}:{part * 2}:{part}");


//double s = 240;
//double v1 = 3;
//double v2 = 2;
//Console.WriteLine(Math.Abs((s/v1)-(s/v2)));// 40


//int x = 483;
//x = x - 80;
//Console.WriteLine(x);// 403

//Console.WriteLine("Введите трёхзначное число: ");// для любого числа
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine(x = x - x % 100 / 10 * 10);


//int firstNum = 15;// 15
//firstNum = firstNum + 6;// 21 
//int secondNum = -firstNum;// -21
//int res = -firstNum - 2 * secondNum;// -(-21) - (2 * -21) = 21
//Console.WriteLine(res);


//int x = 17;
//x = 17 / 10;
//Console.WriteLine(x);// 1


//     МАГАЗИН
//Console.Write("Введите количество монет: ");
//decimal money = decimal.Parse(Console.ReadLine());
//decimal butter = 150.0m;
//decimal bread = 50.0m;
//decimal tea = 40.0m;
//Console.WriteLine($"Хлеб:{bread}\nМасло:{butter}\nЧай:{tea}");
//Console.Write("Введите количество хлеба: ");
//int n1 = int.Parse(Console.ReadLine());
//Console.Write("Введите количество масла: ");
//int n2 = int.Parse(Console.ReadLine());
//Console.Write("Введите количество чая: ");
//int n3 = int.Parse(Console.ReadLine());
//Console.WriteLine($"{"Хлеб", -8} {bread,-8} {n1,-8} {bread * n1,-8}");
//Console.WriteLine($"{"Масло", -8} {butter,-8} {n2,-8} {butter * n2,-8}");
//Console.WriteLine($"{"Чай", -8} {tea,-8} {n3,-8} {tea * n3,-8}");
//Console.WriteLine($"Итого \t {bread * n1 + butter * n2 + tea * n3}");
//Console.WriteLine($"Остаток \t {money - (bread * n1 + butter * n2 + tea * n3)}");
