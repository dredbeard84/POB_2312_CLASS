// Урок 37, Тема 29: Перечисления (enumeration)


//Console.WriteLine(ToRussian(PrintMessage()));
//DayTime PrintMessage()
//{
//    int hour = DateTime.Now.Hour;
//    DayTime dayTime;
//    if (hour > 5 && hour < 12) dayTime = DayTime.Morning;
//    else if (hour > 12 && hour < 17) dayTime = DayTime.Afternoon;
//    else if (hour > 17 && hour < 24) dayTime = DayTime.Evening;
//    else dayTime = DayTime.Night;
//    return dayTime;
//}
//string ToRussian(DayTime dayTime)
//{
//    switch ((int)dayTime)
//    {
//        case 0: return "Доброе утро!";
//        case 1: return "Добрый день!";
//        case 2: return "Добрый вечер!";
//    }
//    //switch (dayTime)
//    //{
//    //    case DayTime.Morning: return "Доброе утро!";
//    //    case DayTime.Afternoon: return "Добрый день!";
//    //    case DayTime.Evening: return "Добрый вечер!";
//    //}
//    return "Доброй ночи!";
//}
//enum DayTime
//{
//    //Morning = 1, // при таком условии case будет начинаться так же с 1
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}


//Console.Write("Введите 1-е число: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите 2-е число: ");
//double b = double.Parse(Console.ReadLine());
//DoOperation(a, b, Operation.Add);
//DoOperation(a, b, Operation.Substruct);
//DoOperation(a, b, Operation.Multiply);
//DoOperation(a, b, Operation.Divide);
//void DoOperation(double x, double y, Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Substruct => x - y,
//        Operation.Multiply => x * y,
//        Operation.Divide => x / y
//    };
//    Console.WriteLine(result);
//}
//enum Operation
//{
//    Add,
//    Substruct,
//    Multiply,
//    Divide
//}


//string moon = "Moon";
//// проверка на принадлежность луны к планетам
//if (!Enum.IsDefined(typeof(DistanceSun), moon)) Console.WriteLine("Не планета!");
//// результат в ввиде таблицы
//foreach (DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
//{
//    Console.WriteLine("{0, -10} {1, -10} {2, 20}",
//        Enum.Format(typeof(DistanceSun), item, "G"),// строка
//        Enum.Format(typeof(DistanceSun), item, "D"),// число в десятичной системе
//        Enum.Format(typeof(DistanceSun), item, "X"));// число в шестнадцатиричной системе
//}
//enum DistanceSun : ulong
//{
//    Sun = 0,
//    Mercury = 5790000,
//    Venus = 108200000,
//    Earth = 149600000,
//    Mars = 227900000,
//    Jupiter = 708300000,
//    Saturn = 1427000000,
//    Uranus = 2870000000,
//    Neptune = 4496000000,
//    Pluto = 5946000000
//}
