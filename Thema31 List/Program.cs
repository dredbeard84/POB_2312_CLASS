// Урок 38, тема 31: List

//using System.Collections;

//ArrayList list = new ArrayList();
//Console.WriteLine(list.Count);// 0
//Console.WriteLine(list.Capacity);// 0
//list.Add("first");
//Console.WriteLine(list.Count);// длина содержит 1 элемент
//Console.WriteLine(list.Capacity);// объём может содержать до 4 элементов
//list.Add(1);
//list.Add(2.1);
//list.Add('3');
//list.Add("4");
//Console.WriteLine(list.Count);// 5
//Console.WriteLine(list.Capacity);// 8 
//list.Insert(2, "second");// добавление по индексу - замена элемента с индексом 2 на second со смещенем (вставляет между)
//for (int i = 0; i < list.Count; i++) Console.Write(list[i] + " ");
//Console.WriteLine();
//list.Remove('3');
//foreach (var item in list) Console.Write(item + " ");
//Console.WriteLine();
//list.RemoveAt(3);
//foreach (var item in list) Console.Write(item + " ");
//Console.WriteLine();
//Console.WriteLine(list.Contains(1));
//list.Sort();
//Console.WriteLine(list.BinarySearch(1));
//list.Clear();


/* практика: 
Разработайте программу для управления списком контактов. 
Каждый контакт должен содержать имя и номер телефона.
    
Реализуйте следующие функции:
        Добавление нового контакта в список.
        Удаление контакта по имени.
        Поиск контакта по имени или номеру телефона.
        Вывод списка всех контактов. */

Note note = new Note();
do
{
    Console.Clear();
    Console.Write("Выберите действие:\n" +
        "[1] Добавить новый контакт\n" +
        "[2] Удалить контакт\n" +
        "[3] Поиск контакта по имени и номеру телефона\n" +
        "[4] Выход\n\n");
    note.Print();
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите имя контакта: ");
                string name = Console.ReadLine()!;
                Console.Write("Введите номер телефона: ");
                string phone = Console.ReadLine()!;
                Contact contact = new Contact(name, phone);
                note.Add(contact);
            }
            break;
        case 2:
            {
                Console.Write("Выберите способ:\n" +
                    "[1] По индексу\n" +
                    "[2] По имени\n" +
                    "[3] По номеру телефона\n");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.Write("Введите индекс: ");
                            int index;
                            int.TryParse(Console.ReadLine(), out index);
                            note.Remove(index);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введите имя: ");
                            string name = Console.ReadLine()!;
                            Contact contact = note.FindByName(name);
                            note.Remove(contact);
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Введите номер: ");
                            string phone = Console.ReadLine()!;
                            Contact contact = note.FindByPhone(phone);
                            note.Remove(contact);
                        }
                        break;
                }
            }
            break;
        case 3:
            {
                Console.Write("Выберите способ:\n" +
                    "[1] По имени\n" +
                    "[2] По номеру телефона\n");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.Write("Введите имя: ");
                            string name = Console.ReadLine()!;
                            Contact contact = note.FindByName(name);
                            Console.WriteLine(contact.getName() + " " + contact.getPhone());
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введите номер: ");
                            string phone = Console.ReadLine()!;
                            Contact contact = note.FindByPhone(phone);
                            Console.WriteLine(contact.getName() + " " + contact.getPhone());
                            Console.ReadKey();
                        }
                        break;
                }
            }
            break;
    }
    if (n == 4) break;
}
while (true);
class Note
{
    private List<Contact> contacts;
    public Note()
    {
        contacts = new List<Contact>();
    }
    public void Add(Contact contact)
    {
        contacts.Add(contact);
    }
    public void Remove(Contact contact)
    {
        contacts.Remove(contact);
    }
    public void Remove(int n)
    {
        contacts.RemoveAt(n - 1);
    }
    public Contact FindByName(string name)
    {
        foreach (Contact i in contacts)
        {
            if (i.getName() == name)
            {
                return i;
            }
        }
        return null;
    }
    public Contact FindByPhone(string phone) => contacts.FirstOrDefault(p => p.getPhone() == phone)!;
    public void Print()
    {
        int i = 0;
        foreach (Contact item in contacts)
        {
            Console.WriteLine(++i + ". " + item.getName() + " " + item.getPhone());
        }
    }
}
class Contact
{
    private string name;
    private string phone;
    public Contact(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }
    public string getName() => name;
    public string getPhone() => phone;
}
