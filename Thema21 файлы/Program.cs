// Тема 21: работа с файлами

// Урок 26

using System.Text;

// синхронное чтение
//using (FileStream fs = new FileStream("file.txt", FileMode.Open))
//{
//    byte[] b = new byte[fs.Length];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while (fs.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}


// асинхронная запись в файл
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//using (FileStream fStream = new FileStream("First.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fStream.WriteAsync(buffer, 0, buffer.Length);
//    Console.WriteLine("Файл сохранён");
//}


//// асинхронное чтение из файла
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    byte[] buffer = new byte[fStream.Length];
//    await fStream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}


//// асинхронное чтение части файла
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    fStream.Seek(-11, SeekOrigin.End);// -11 == последние 11 байт (каждая буква == 2 байта), End == с конца
//    byte[] buffer = new byte[11];// здесь тоже 11 байт
//    await fStream.ReadAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}


// StreamReader

// Работа с текстовыми файлами

//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//using (StreamWriter writer = new StreamWriter("First.txt", false))// false - перезапишет файл
//{
//    await writer.WriteAsync(text);// без Line, чтобы не пеерносил на новую строку при добавлении
//}

//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//using (StreamWriter writer = new StreamWriter("First.txt", true))// true - добавит в файл
//{
//    await writer.WriteLineAsync(text);
//}


// Чтение из файла

//using (StreamReader reader = new StreamReader("First.txt"))
//{
//    string text = await reader.ReadToEndAsync();
//    Console.WriteLine(text);
//}

//using (StreamReader reader = new StreamReader("First.txt"))
//{
//    string text = "";
//    while ((text = await reader.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(text);
//    }
//}


// Классы File и FileInfo

//DriveInfo[] dives = DriveInfo.GetDrives();
//foreach (DriveInfo drive in dives)
//{
//    Console.WriteLine(drive.Name);
//    Console.WriteLine(drive.DriveType);
//    if (drive.IsReady)
//    {
//        Console.WriteLine(drive.TotalSize);// чтобы получить размер в байтах, то .TotalSize/1024 == кБ
//        Console.WriteLine(drive.TotalFreeSpace);
//        Console.WriteLine(drive.VolumeLabel);
//    }
//    Console.WriteLine();
//}


//string dirName = "C:\\";// == @"C:\" - один \
//if (Directory.Exists(dirName))
//{
//    Console.WriteLine("Папки: ");
//    string[] dirs = Directory.GetDirectories(dirName);
//    foreach (string dir in dirs)
//    {
//        Console.WriteLine(dir);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы: ");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string file in files)
//    {
//        Console.WriteLine(file);
//    }
//    Console.WriteLine();
//}


//DirectoryInfo dirInfo = new DirectoryInfo(dirName);
//if (dirInfo.Exists)
//{
//    Console.WriteLine("Папки: ");
//    DirectoryInfo[] dirs = dirInfo.GetDirectories();
//    foreach (DirectoryInfo dir in dirs)
//    {
//        Console.WriteLine(dir.FullName);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы: ");
//    FileInfo[] files = dirInfo.GetFiles();
//    foreach (FileInfo file in files)
//    {
//        Console.WriteLine(file.Name);
//    }
//    Console.WriteLine();
//}


// ПРАКТИКА 1


/* # 3. Копирование файла
        Попросите пользователя ввести имя исходного файла и имя файла назначения.
        Скопируйте содержимое исходного файла в файл назначения. */

//string file1 = "File.txt";
//string file2 = "First.txt";
//FileInfo fi = new FileInfo(file1);
//if (fi.Exists)
//{
//    fi.CopyTo(file2, true);
//}


/* # 4. Поиск файлов по расширению
        Попросите пользователя ввести путь к папке и расширение файла.
        Найдите все файлы с указанным расширением в указанной папке и выведите их имена на экран. */

//Console.Write("Введите путь к папке: ");
//string path = Console.ReadLine();
//DirectoryInfo dirInfo = new DirectoryInfo(@$"{path}");// @, чтобы не присать \\
//FileInfo[] files = dirInfo.GetFiles();
//Console.Write("Введите расширение для поиска: ");
//string extension = Console.ReadLine();
//foreach (FileInfo file in files)
//{
//    if (file.Extension == extension) Console.WriteLine(file.FullName);
//}


/* # 5: Удаление файла
        Попросите пользователя ввести имя файла для удаления.
        Удалите указанный файл, если он существует. */

//Console.Write("Введите путь к папке: ");
//string path = Console.ReadLine();
//DirectoryInfo dirInfo = new DirectoryInfo(@$"{path}");// @, чтобы не присать \\
//FileInfo[] files = dirInfo.GetFiles();
//Console.Write("Введите расширение для поиска: ");
//string extension = Console.ReadLine();
//foreach (FileInfo file in files)
//{
//    if (file.Extension == extension) Console.WriteLine(file.Delete);
//}

// обсудить удаление

