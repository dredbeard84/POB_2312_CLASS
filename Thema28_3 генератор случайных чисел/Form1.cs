namespace Thema28_3_генератор_случайных_чисел
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Generator generator = new Generator(int.Parse(tbFrom.Text), int.Parse(tbUntil.Text));
                tbResult.Text = generator.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}