namespace ArrayLibrary
{
    public class ArrayClass<T> // <T> - дженерик
    {
        private T[]? mas;// T - универсальный параметр
        public ArrayClass(T[]? mas)
        {
            this.mas = mas;
        }
        public void Fill()
        {
            Random random = new Random();
            
        }
    }
}