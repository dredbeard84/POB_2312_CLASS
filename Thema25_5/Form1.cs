using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Thema25_5
{
    public partial class Form1 : Form
    {
        public double Price;
        public Form1()
        {
            InitializeComponent();
        }
        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxMaterial.SelectedIndex)
            {
                case 0: Calculate("alu.jpeg", 300); break;
                case 1: Calculate("plastic.jpg", 150); break;
                case 2: Calculate("wood.jpg", 120); break;
                case 3: Calculate("bamboo.jpg", 180); break;
            }
        }
        private void btResult_Click()
        {
            lbResult.Text = (double.Parse(tbxWidth.Text) * double.Parse(tbxHeight.Text) * Price).ToString("c");
        }
        private void Calculate(string path, double price)
        {
            pbxMaterial.Image = Image.FromFile(path);
            Price = price;
            btResult_Click();
        }
    }
}
