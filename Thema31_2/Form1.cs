namespace Thema31_2
{
    public partial class Form1 : Form
    {
        public Library library;
        private List<Book> books;
        public Form1()
        {
            InitializeComponent();
            library = new Library();
            books = library.getBooks();
            toolStripStatusLabelCountBook.Text = "Количество книг: " + library.getCount().ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(TextBoxTitle.Text,
                                 textBoxAuthor.Text,
                       int.Parse(textBoxYear.Text));
            library.Add(book);
            UpdateForm();
        }
        private void UpdateForm()
        {
            listBoxTitle.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxYear.Items.Clear();
            foreach (Book book in books)
            {
                listBoxTitle.Items.Add(book.getTitle());
                listBoxAuthor.Items.Add(book.getAuthor());
                listBoxYear.Items.Add(book.getYear());
            }
            TextBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxYear.Text = "";
            toolStripStatusLabelCountBook.Text = "Количество книг: " + library.getCount().ToString();
        }
        private void TextBoxFiltr_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxFiltr.Text.Length != 0)
            {
                books = library.getBooksByCriteria(TextBoxFiltr.Text).ToList();
            }
            else
            {
                books = library.getBooks();
            }
            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = listBoxTitle.SelectedItem.ToString()!;
            library.Remove(title);
            UpdateForm();
        }
    }
}
//