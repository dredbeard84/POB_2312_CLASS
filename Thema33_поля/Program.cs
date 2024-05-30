/*
переменные:
- локальные (принадлежать методу)
- глобальные (принадлежат классу)

статическое - принадлежит классу
нестат. - принадлежит объекту класса

класс = шаблон (как создать данные) члены класса: поля (хранят данные), методы (хранят поведение данных), 3-й, 4-й
объект - хранит данные

Общие соглашения о коде
https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions

telega:
```
(код)
```

 */

/*
Алгоритмы сортировки:
а) пузырьком
б) выбором
в) вставками
г) делением
д) слиянием
 */

using System.Diagnostics;

namespace Thema33
{
    class Program
    {

        static int[] bubble;
        static int[] selection;
        public static void Main(string[] args)
        {
            CreateRandomArr(30000);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            BubbleSort(bubble);
            sw.Stop();
            long timeBubbleSort = sw.ElapsedMilliseconds;

            sw.Start();
            SelectionSort(selection);
            sw.Stop();
            long timeSelectionSort = sw.ElapsedMilliseconds;

            Console.WriteLine(timeBubbleSort);
            Console.WriteLine(timeSelectionSort);
        }
        public static void BubbleSort(int[] array)
        {
            int arrLength = array.Length - 1;
            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minNumberIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minNumberIndex])
                    {
                        minNumberIndex = j;
                    }
                    int temp = array[minNumberIndex];
                    array[minNumberIndex] = array[i];
                    array[i] = temp;
                }
            }

        }
        public static void CreateRandomArr(int length)
        {
            Random random = new Random();
            bubble = new int[length];
            selection = new int[length];
            for (int i = 0; i < length; i++)
            {
                int temp = random.Next(int.MinValue, int.MaxValue);
                bubble[i] = temp;
                selection[i] = temp;
            }
        }

    }
}
