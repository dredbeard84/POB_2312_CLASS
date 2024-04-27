namespace ArrayLibrary
{
    public class ArrayClass<T> // <T> - дженерик
    {
        private T[]? mas;// T - универсальный параметр
        public ArrayClass(T[]? mas)
        {
            this.mas = mas;
        }
        public void Fill(int low, int high)
        {
            Random random = new Random();
            if (mas[0].GetType() == typeof(int))
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = (int)random.Next(low, high);
                }
            }
        }
    }
}
