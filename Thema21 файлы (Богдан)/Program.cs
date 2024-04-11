// Урок 27 (с Богданом)

// выравнивание Ctrl + K + D

namespace FileOperator2312
{
    internal class Progamm
    {
        static void Main(string[] args)
        {
            //File.WriteAllText("MyFile.txt", "Привет, мир!");// относительный путь к файлу

            //string[] lines =
            //{
            //    "Привет",
            //    "Пока",
            //    "Как дела",
            //    "Цыфра"
            //};
            //File.WriteAllLines("MyFileLines.txt", lines);

            //string content = File.ReadAllText("MyFile.txt");
            //Console.WriteLine(content);

            //string[] content = File.ReadAllLines("MyFileLines.txt");
            //for (int i = 0; i < content.Length; i++)
            //{
            //    Console.WriteLine(content[i]);
            //}



            // ПРАКТИКА 3

            //Console.Write("Выберите действие: \n" +
            //    "[1] Создать файл\n" +
            //    "[2] Читать файл\n" +
            //    "[3] Удалить файл\n" +
            //    "[4] Создать папку\n" +
            //    "[5] Удалить папку\n");
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1: createFile(); break;
            //    case 2: readFile(); break;
            //    case 3: deleteFile(); break;
            //    case 4: createFolder(); break;
            //    case 5: deleteFolder(); break;
            //    default: Console.Write("Такой функции нет"); break;
            //}
            //void createFile()
            //{
            //    File.WriteAllText(fullPath(), "");
            //}
            //void readFile()
            //{
            //    Console.WriteLine(File.ReadAllText(fullPath()));
            //}
            //void deleteFile()
            //{                
            //    File.Delete(fullPath());
            //}
            //void createFolder()
            //{
            //    Directory.CreateDirectory(fullPath());
            //}
            //void deleteFolder()
            //{
            //    Directory.Delete(fullPath());
            //}
            //string fullPath()
            //{
            //    Console.Write("Укажите путь к файлу: ");
            //    string filePath = Console.ReadLine();
            //    Console.Write("Введите имя файла: ");
            //    string fileName = Console.ReadLine() + ".txt";
            //    return (@$"{filePath}\{fileName}");
            //}
            //Console.WriteLine();


            //string[] directories = Directory.GetDirectories(@"C:\Users\C1NB3\source\repos\HW_CIFRA\POB_2312_CLASS\Thema21 файлы\bin\Debug\net6.0");
            //for (int i = 0; i < directories.Length; i++)
            //{
            //    string[] pathParts = directories[i].Split(@"\");
            //    Console.WriteLine(pathParts[pathParts.Length-1]);
            //}
            // сравнить со скрином


            // ПРАКТИКА 4

            // # 4


            for (int i = 0; i < 10; i++)
            {
                Directory.CreateDirectory(Name());
            }
            string Name()
            {
                Random random = new Random();
                string abc = "abcdefghijklmnopqrstuvwxyz";
                int length = 10;
                string res = "";
                do
                {
                    for (int i = 0; i < length; i++)
                    {
                        res += abc[random.Next(0, abc.Length)];
                    }
                } while (Directory.Exists(res));
                return (res);
            }
        }
    }
}
