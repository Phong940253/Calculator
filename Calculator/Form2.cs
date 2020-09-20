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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool thucHienPhepTinh = false;
        // quy uoc false la chua co nhan bat ki dau +, -, x, /
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (btnResult.Text == "0") btnResult.Text = "";
            if (!thucHienPhepTinh) btnResult.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(btnResult.Text))
            {
                if (btnResult.Text.Length == 1)
                {
                    btnResult.Text = "0";
                }
                else
                {
                    StringBuilder temp = new StringBuilder(btnResult.Text);
                    temp.Remove(temp.Length - 1, 1);
                    btnResult.Text = temp.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnResult.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnResult.Text = "0";
        }
    }
}
