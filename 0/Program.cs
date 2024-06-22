//Console.Title = "Планировщик задач";
//const int COLUMNS = 5;

Console.Title = "Список задач";
const int COLUMNS = 2;

const int ROWS = 1;
int tasks = 1;
int rows = ROWS + tasks;

string[,] table = new string[rows, COLUMNS];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < COLUMNS; j++)
    {
        table[i, j] = " . ";
        table[0, 0] = "НОМЕР";
        table[0, 1] = "ЗАДАЧА";
        //table[0, 2] = "ДАТА";
        //table[0, 3] = "ВРЕМЯ";
        //table[0, 4] = "ПРИОРИТЕТ";
        //if (i > 0)
        //{
        //    table[i, 0] = taskNumber.ToString();
        //}
        Console.Write($"{table[i, j],-10}");
    }
    Console.WriteLine();
}
Console.WriteLine();


//Console.WriteLine("Меню:\n" +
//    "[1] Добавить\n" +
//    "[2] Удалить\n" +
//    "[3] Изменить\n" +
//    "[4] Найти\n" +
//    "[5] Выход\n");
//int number = int.Parse(Console.ReadLine()!);

do
{
    Console.Write("Введите название задачи: ");
    string taskName = Console.ReadLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            table[tasks, 1] = taskName;
            Console.Write($"{table[i, j],-10}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    tasks++;


} while (true);



//Console.Write("Введите максимальное количество задач: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine();

//string[,] mas = new string[n, 4];

//bool start = true;
//int count = 0;          // количество задач
//int number;
//string search = "";


//do
//{
//    Console.Clear();

//    Console.WriteLine($"Всего задач {n}, свободных {n - count}\n");

//    Console.WriteLine("Меню:");
//    Console.WriteLine("Выберите действие:\n" +
//        "[1] Добавить\n" +
//        "[2] Удалить\n" +
//        "[3] Переписать\n" +
//        "[4] Найти\n" +
//        "[5] Выход\n");

//    if (search != "")
//    {
//        for (int i = 0; i < count; i++)
//        {
//            if (mas[i, 0].StartsWith(search))
//            {
//                Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}{mas[i, 2],-10}{mas[i, 3],5}");
//            }
//        }
//    }

//    else
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}{mas[i, 2],-10}{mas[i, 3],5}");
//        }
//    }

//    try
//    {
//        Console.Write("Введите действие:");
//        number = int.Parse(Console.ReadLine());

//        switch (number)
//        {
//            case 1:
//                {
//                    if (count < n)
//                    {
//                        Console.Write("Введите название задачи:");
//                        string name = Console.ReadLine();

//                        Console.Write("Введите дату задачи:");
//                        string date = Console.ReadLine();

//                        Console.Write("Введите время задачи:");
//                        string time = Console.ReadLine();

//                        Console.Write("Введите приоритет задачи:");
//                        string priority = Console.ReadLine();

//                        mas[count, 0] = name;
//                        mas[count, 1] = date;
//                        mas[count, 2] = time;
//                        mas[count, 3] = priority;

//                        count++;
//                    }

//                    else
//                    {
//                        Console.WriteLine("Нет свободных мест");
//                        Console.ReadKey();
//                    }
//                }
//                break;

//            case 2:
//                {
//                    Console.Write("Введите номер задачи для удаления:");
//                    int m = int.Parse(Console.ReadLine());

//                    for (int i = 0; i < mas.GetLength(1); i++)
//                    {
//                        mas[m - 1, i] = "";
//                    }
//                }
//                break;

//            case 3:
//                {
//                    Console.Write("Введите номер задачи для изменения:");
//                    int m = int.Parse(Console.ReadLine());

//                    Console.Write("Введите название задачи:");
//                    string name = Console.ReadLine();

//                    Console.Write("Введите дату задачи:");
//                    string date = Console.ReadLine();

//                    Console.Write("Введите время задачи:");
//                    string time = Console.ReadLine();

//                    Console.Write("Введите приоритет задачи:");
//                    string priority = Console.ReadLine();

//                    mas[m, 0] = name;
//                    mas[m, 1] = date;
//                    mas[m, 2] = time;
//                    mas[m, 3] = priority;
//                }
//                break;

//            case 4:
//                {
//                    Console.Write("Введите задачу для поиска:");
//                    search = Console.ReadLine();
//                }
//                break;

//            case 5:
//                {
//                    start = false;
//                }
//                break;

//            default:
//                {
//                    Console.WriteLine("Введите правильное действие");
//                    Console.ReadKey();
//                }
//                break;
//        }
//    }

//    catch
//    {

//    }
//}
//while (start);
