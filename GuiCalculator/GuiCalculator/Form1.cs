using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCalculator
{
    public partial class Form1 : Form
    {
        long num1, num2, result;
        string nz="";
        public Form1()
        {
            InitializeComponent();
        }
        private void clear(object sender, EventArgs e) {
            nz=txtValue.Text = "0";
            num1 = num2 = 0;
        }
        private void OnnumClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            long v = int.Parse(b.Text);
            long val = int.Parse(txtValue.Text);
            val = val * 10 + v;
            txtValue.Text = val.ToString();
        }
        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;
            nz = b.Text;
            num1 = int.Parse(txtValue.Text);
            txtValue.Text = "0";
        }
        private void equalsbtn(object sender, EventArgs e)
        {
            num2 = int.Parse(txtValue.Text);
            switch (nz){
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                        txtValue.Text = "You cant devide by 0";
                    result = num1 / num2;
                    break;
            }
            txtValue.Text = result.ToString();
        }
    }
}

