// урок 22

//Игра волки и кролики

//Random random = new Random();
//char[] rabbits = new char[random.Next(10, 20)];
//int[,] rabbitGeo = new int[rabbits.Length, 3];
//for (int i = 0; i < rabbitGeo.GetLength(0); i++)
//{
//    int k = random.Next(20);
//    int m = random.Next(20);
//    rabbitGeo[i, 0] = i;
//    rabbitGeo[i, 1] = k;
//    rabbitGeo[i, 2] = m;
//}
//char[] wolfs = new char[random.Next(5) + 2];
//char[] female = new char[random.Next(5) + 2];
//char[,] square = new char[20, 20];
//int rCount = rabbits.Length;
//int wCount = wolfs.Length;
//int fCount = female.Length;
//bool play = true;
//do
//{

//    Console.Clear();
//    for (int i = 0; i < square.GetLength(0); i++)
//    {
//        for (int j = 0; j < square.GetLength(1); j++)
//        {
//            square[i, j] = '.';
//        }
//    }
//    for (int i = 0; i < rabbits.Length; i++)
//    {
//        int k = rabbitGeo[i, 1] + random.Next(-8, 8);
//        while (k < 0 || k > 19)
//        {
//            k = rabbitGeo[i, 1] + random.Next(-8, 8);
//        }
//        int m = rabbitGeo[i, 2] + random.Next(-8, 8);
//        while (m < 0 || m > 19)
//        {
//            m = rabbitGeo[i, 2] + random.Next(-8, 8);
//        }
//        square[k, m] = 'R';
//        rabbitGeo[i, 0] = i;
//        rabbitGeo[i, 1] = k;
//        rabbitGeo[i, 2] = m;
//        int probably = (int)(random.NextDouble() * 100);
//        if (probably == 20) Array.Resize(ref rabbits, rabbits.Length + 1);
//    }
//    for (int i = 0; i < wolfs.Length; i++)
//    {

//        int k = random.Next(20);
//        int m = random.Next(20);
//        if (square[k, m] == 'R')
//        {
//            Array.Resize(ref rabbits, rabbits.Length - 1);
//        }
//        square[k, m] = 'W';
//    }
//    for (int i = 0; i < square.GetLength(0); i++)
//    {
//        for (int j = 0; j < square.GetLength(1); j++)
//        {
//            if (square[i, j] != 'R' && square[i, j] != 'W') square[i, j] = '.';
//            Console.Write(square[i, j]);
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine("Кролики:" + rabbits.Length);
//    Console.WriteLine("Волки:" + wolfs.Length);
//    Thread.Sleep(800);
//}
//while (play);


// урок 23

// змейка


char[,] grid = new char[18, 18];
char[] snake = new char[4];
Array.Fill(snake, 'X');
int[,] geoSnake = new int[4, 2];
for (int i = 0; i < geoSnake.GetLength(1); i++)
{
    geoSnake[0, i] = snake.Length - i - 1;
}

char geo = 'd';
do
{
    Console.Clear();
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            grid[i, j] = '.';
        }
    }
    switch (geo)
    {
        case 'd':
        case 'в':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = ++geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 's':
        case 'ы':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = ++geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'a':
        case 'ф':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = --geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'w':
        case 'ц':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = --geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
    }

    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (Console.KeyAvailable)
    {
        geo = Console.ReadKey().KeyChar;
    }
    Thread.Sleep(500);
}
while (true);
