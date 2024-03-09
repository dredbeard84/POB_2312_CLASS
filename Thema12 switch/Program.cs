// Тема 12. Операторы Switch/Case


//Console.Write("Введите номер дня недели: ");
//byte n = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: Console.WriteLine("Понедельник"); break;
//    case 2: Console.WriteLine("Вторник"); break;
//    case 3: Console.WriteLine("Среда"); break;
//    case 4: Console.WriteLine("Четверг"); break;
//    case 5: Console.WriteLine("Пятница"); break;
//    case 6: Console.WriteLine("Суббота"); break;
//    case 7: Console.WriteLine("Воскресенье"); break;
//    default: Console.WriteLine("Ошибка: такого дня недели нет"); break;
//}


// время года по номеру месяца
//Console.Write("Введите номер месяца: ");
//byte m = byte.Parse(Console.ReadLine());
//// запросить температуру
//// ввести переменую для температуры
//switch (m)
//{
//    case 12: case 1: case 2:
//        {
//            Console.WriteLine("зима"); break;
//            // если температура..
//            // тогда и т.п.
//        }
//    case 3: case 4: case 5: Console.WriteLine("весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("осень"); break;
//    default: Console.WriteLine("нет такого месяца"); break;
//}


// практикум 1

//Random random = new Random();
//Console.WriteLine("Выберите, какие числа сгенерировать\n" +
//    "1 - целые\n" +
//    "2 - с плавающей точкой\n" +
//    "3 - числа в диапазоне\n");
//    Console.Write("Введите число: ");
//byte n = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: 
//        {
//            Console.Write("Введте максимальное значение: ");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine(random.Next(max) + 1);
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введте максимальное значение: ");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble() * max:F2}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введте минимальное значение: ");
//            int min = int.Parse(Console.ReadLine());
//            Console.Write("Введте максимальное значение: ");
//            int max = int.Parse(Console.ReadLine());
//            if (min > max)// поменять местами
//            {
//                int temp = max;
//                max = min;
//                min = temp;
//            }
//            Console.WriteLine(random.Next(min,max));
//        }
//        break;
//    default: Console.WriteLine("Такого варианта нет"); break;
//}

/* Практикум 4
 * 
 * Менеджер задач:
 * пользователь может выбрать, какую задачу он хочет создать (напоминание о событии, список дел и т.п.),
 * а также указать параметры задачи (дата и время, описание и т.п.)
*/

//Console.WriteLine("Выберите, какую задачу создать\n" +
//    "1 - напоминание\n" +
//    "2 - событие\n" +
//    "3 - список дел\n");
//Console.Write("Введите число (1, 2 или 3): ");
//byte n = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Введите время: ");
//            string time = Console.ReadLine();
//            Console.WriteLine("О чём напомнить?: ");
//            string what = Console.ReadLine();
//            Console.WriteLine($"{time} - {what}");
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введте дату события: ");
//            string data = Console.ReadLine();
//            Console.WriteLine("Введите событие: ");
//            string what = Console.ReadLine();
//            Console.WriteLine($"{data} - {what}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введте дело #1: ");
//            string business1 = Console.ReadLine();
//            Console.Write("Введте дело #2: ");
//            string business2 = Console.ReadLine();
//            Console.Write("Введте дело #3: ");
//            string business3 = Console.ReadLine();
//            Console.WriteLine($"Ваш список дел на сегодня:\n" +
//                            $"1) {business1}\n" +
//                            $"2) {business2}\n" +
//                            $"3) {business3}\n"); ;
//        }
//        break;
//    default: Console.WriteLine("Такого значения нет"); break;
//}


// камень - ножницы - бумага
//Console.WriteLine("Введите камень, ножницы или бумага");
//string user = Console.ReadLine();
//Random random = new Random();
//string pc = "";// обязательна инициализация
//switch (random.Next(1, 4))
//{
//    case 1: pc = "камень"; break;
//    case 2: pc = "ножницы"; break;
//    case 3: pc = "бумага"; break;
//}
//if (user == pc) Console.WriteLine("Ничья");
//else if (user == "ножницы" && pc == "бумага");
//// и т.д.
//Console.WriteLine(user + " " + pc);


// практикум 2-2

//Random random = new Random();
//int sum = 0;
//// 1
//int n = random.Next(100);
//int m = random.Next(100);
//int var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}=");} break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ: ");
//int res = int.Parse(Console.ReadLine());
//if (res == var) sum++;

//// 2
//n = random.Next(100);
//m = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); } break;
//    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//}
//Console.Write("Введите ответ: ");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;

//// 3 - 5 копипастом

//Console.WriteLine($"Ваш результат: {sum}");
//switch (sum)
//{
//    case 0: case 1: Console.WriteLine("Единица"); break;
//    case 2: Console.WriteLine("Два"); break;
//    case 3: Console.WriteLine("Три"); break;
//    case 4: Console.WriteLine("Четыре"); break;
//    case 5: Console.WriteLine("Пять"); break;
//}


/*Задачник 2.9
 * С начала 1990 года по некоторый день прошло n месяцев и 2 дня.
 * Присвоить целочисленной величине x значение 1, 2, ..., 11 или 12 в зависимости от того, каким месяцем (январем, февралем и т. п.) является месяц этого дня.
 * Например, при n 3 значение х равно 4.
 */

//Console.Write("Введите количество месяцев прошедших с начала 1990 года: ");
//int n = int.Parse(Console.ReadLine());
//switch (n % 12 + 1)
//{
//    case 1: Console.WriteLine("Январь"); break;
//        // ..
//    case 12: Console.WriteLine("Декабрь"); break;
//}


// рубли

// если %10 = 1 рубля
//Console.Write("Введите количество рублей: ");
//int rub = int.Parse(Console.ReadLine());
//if (rub % 100 >= 11 && rub % 100 <= 14) Console.WriteLine($"{rub} рублей");
//else
//    switch (rub % 10)
//    {
//        case 1: Console.WriteLine("рубль");break;
//        case 2: case 3: case 4: Console.WriteLine("рубля");break;
//        default: Console.WriteLine("рублей"); break;
//    }


// задачник 4.110

//Console.Write("Введите номер карты (от 6 до 14): ");
//byte n = byte.Parse(Console.ReadLine());
//Console.Write("Введите номер масти (от 1 до 4): ");
//byte m = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 6: Console.Write("шестёрка "); break;
//    case 7: Console.Write("семёрка "); break;
//    case 8: Console.Write("восьмёрка "); break;
//    case 9: Console.Write("девятка "); break;
//    case 10: Console.Write("десятка "); break;
//    case 11: Console.Write("валет "); break;
//    case 12: Console.Write("дама "); break;
//    case 13: Console.Write("король "); break;
//    case 14: Console.Write("туз "); break;
//    default: Console.Write("Ошибка: такого дня недели нет"); break;
//}
//switch (m)
//{
//    case 1: Console.WriteLine("пик"); break;
//    case 2: Console.WriteLine("треф"); break;
//    case 3: Console.WriteLine("бубен"); break;
//    case 4: Console.WriteLine("червей"); break;
//    default: Console.WriteLine("Ошибка: такого дня недели нет"); break;
//}


// задачник 4.113

//Console.WriteLine("Введите число месяца: ");
//byte n = byte.Parse(Console.ReadLine());
//Console.WriteLine("Введите порядковый номер месяца: ");
//byte m = byte.Parse(Console.ReadLine());
//switch (m)
//{
//    case 1: 
//}
