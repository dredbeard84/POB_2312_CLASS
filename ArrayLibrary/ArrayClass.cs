namespace ArrayLibrary
{
    public class ArrayClass//<T> // <T> - дженерик
    {
//        private object[]? mas;// T - универсальный параметр

        public ArrayClass(object[]? mas)
        {
            this.mas = mas;
        }
        public void Fill(int low, int high)
        {
            Random random = new Random();
            if (mas[0].GetType() == typeof(string))
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    string res = String.Empty;
                    for(int j = 0; j < high; j++)
                        res += (char)random.Next(60, 127);
                    mas[i] = res;
                }
            }
        }
    }
}
