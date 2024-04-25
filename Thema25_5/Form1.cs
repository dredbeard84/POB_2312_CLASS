using System.Reflection;

namespace Thema25_5
{
    public partial class Form1 : Form
    {
        public double price;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxMaterial.SelectedIndex)
            {
                case 0:
                    {
                        pbxMaterial.Image = Image.FromFile("alu.jpeg");
                        price = 300;
                    }
                    break;
                case 1:
                    {
                        pbxMaterial.Image = Image.FromFile("plastic.jpg");
                        price = 150;
                    }
                    break;
                case 2:
                    {
                        pbxMaterial.Image = Image.FromFile("wood.jpg");
                        price = 120;
                    }
                    break;
                case 3:
                    {
                        pbxMaterial.Image = Image.FromFile("bamboo.jpg");
                        price = 180;
                    }
                    break;
            }
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            lbResult.Text = (double.Parse(tbxWidth.Text) * double.Parse(tbxHeight.Text) * price).ToString("c");
        }
    }
}
