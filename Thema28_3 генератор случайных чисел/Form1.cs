namespace Thema28_3_генератор_случайных_чисел
{
    public partial class Form1 : Form
    {
        private Convertor convertor;
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
                MessageBox.Show(ex.Message);//
            }
        }
        private void сbxLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertor = new Convertor(double.Parse(tbNum.Text));
            switch (сbxLong.SelectedIndex)
            {
                case 0: lbRes.Text = convertor.toSM().ToString("F4") + " см"; break;
                case 1: lbRes.Text = convertor.toDM().ToString("F4") + " дм"; break;
                case 2: lbRes.Text = convertor.toMetr().ToString("F4") + " м"; break;
                case 3: lbRes.Text = convertor.toKM().ToString("F4") + " км"; break;
            }
        }
    }
}