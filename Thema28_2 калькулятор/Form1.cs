namespace Thema28_2_калькулятор
{
    public partial class Form1 : Form
    {
        private bool fd = true;// firstDigital ждём первого числа
        private double ac;// accumulator
        public Form1()
        {
            InitializeComponent();
            ac = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //            if (int.Parse(btn.Text) > 0)
            if (btn.Text == "Del")
            {
                lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1, 1);
                if (lbResult.Text.Length == 0)
                {
                    fd = true;
                    lbResult.Text = "0";
                }
                return;
            }
            if (char.Parse(btn.Text) >= '0' && char.Parse(btn.Text) <= '9')
            {
                if (fd)
                {
                    lbResult.Text = btn.Text;
                    fd = false;
                }
                else lbResult.Text += btn.Text;
                return;
            }
            if (char.Parse(btn.Text) == '0')
            {
                if (fd) lbResult.Text = btn.Text;
                if (lbResult.Text != "0") lbResult.Text += btn.Text;
                return;
            }
            if (btn.Text == ",")
            {
                if (fd)
                {
                    lbResult.Text = "0,";
                    fd = false;
                }
                else
                {
                    if (lbResult.Text.IndexOf(",") == -1) lbResult.Text += btn.Text;
                }
                return;
            }
            if (char.Parse(btn.Text) == 'C')
            {
                ac = 0;
                fd = true;
                lbResult.Text = "0";
                return;
            }
            if (char.Parse(btn.Text) == '+' ||
                char.Parse(btn.Text) == '-' ||
                char.Parse(btn.Text) == '*' ||
                char.Parse(btn.Text) == '/' ||
                char.Parse(btn.Text) == '=');
            {
                double n = double.Parse(lbResult.Text);
                if (ac == 0) ac = n;
                else
                {
                    switch (char.Parse(btn.Text))
                    {
                        case '+': ac += n; break;
                        case '-': ac -= n; break;
                        case '=': ac = n; break;
                    }
                    lbResult.Text = ac.ToString("N");
                }
            }
        }
    }
}
