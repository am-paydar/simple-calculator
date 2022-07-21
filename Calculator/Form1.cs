using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private int Num1, Num2;
        private String Op;
        public MainForm()
        {
            InitializeComponent();
        }

        private void NumBtn_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            TextBox.Text += B.Text;
        }
        private void OpBtn_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Op = B.Text;
            Num1 = int.Parse(TextBox.Text);
            PathBox.Text += (TextBox.Text + " " + Op + " ");
            TextBox.Text = "";

        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            TextBox.Text = "";
            PathBox.Text = "";
            Num1 = 0;
            Num2 = 0;

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            Num2 = int.Parse(TextBox.Text);
            PathBox.Text += (TextBox.Text + " ");
            switch (Op)
            {
                case "x":
                    result = Num1 * Num2;
                    break;
                case "/":
                    result = Num1 / Num2;
                    break;
                case "+":
                    result = Num1 + Num2;
                    break;
                case "-":
                    result = Num1 - Num2;
                    break;
            }
            PathBox.Text += "= ";
            TextBox.Text = result.ToString();




        }
    }
}
