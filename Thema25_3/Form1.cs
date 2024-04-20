namespace Thema25_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbMark_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMark.Checked)
            {
                chbMark.Text = "км -> мили";
                lbMark.Text = "км";
            }
            else
            {
                chbMark.Text = "мили -> км";
                lbMark.Text = "мили";
            }
        }

        private void btMark_Click(object sender, EventArgs e)
        {
            const double MILES = 1.62;
            double mark;
            double.TryParse(tbMark.Text, out mark);
            if (chbMark.Checked)
            {
                lbResult.Text = $"{mark} км = {mark / MILES:F2} миль";
            }
            else
            {
                lbResult.Text = $"{mark} миль = {mark * MILES:F2} км";
            }
            tbMark.Focus();
        }

        private void tbMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbMark.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btMark.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void tbMark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbMark.Text.Length > 0)
                {
                    if (double.Parse(tbMark.Text) > double.MaxValue)
                        throw new Exception("Число выходит за границы");
                    else btMark_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
