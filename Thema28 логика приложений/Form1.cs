namespace Thema28_логика_приложений
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    button1.BackColor = GenerateColor();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = GenerateColor();
        }

        private Color GenerateColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }
    }
}
