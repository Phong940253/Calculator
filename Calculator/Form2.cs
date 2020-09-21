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
        private string ketQua = "0";
        private string Memory = "0";
        private bool activeMemory = false;
        private bool thucHienPhepTinh = false;
        // quy uoc false la chua co nhan bat ki dau +, -, x, /
        private bool nhanDauPhay = false;
        private bool tonTaiDauPhay = false;
        private string lastKey = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void xuLiKhiNhanSo(string number)
        {
            if (ketQua == "0") ketQua = "";
            if (!thucHienPhepTinh) ketQua += number;
            if (ketQua == "-00") ketQua = "-0";
            changeResultScreen();
            lastKey = number;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("1");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("2");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("4");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("5");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("7");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("8");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("9");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            xuLiKhiNhanSo("0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ketQua.Length == 1)
                ketQua = "0";
            else if (ketQua == "-0," || (ketQua.Length == 2 && ketQua[0] == '-')) ketQua = "0";
            else ketQua = ketQua.Remove(ketQua.Length - 1, 1);
            changeResultScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketQua = "0";
            changeResultScreen();
            lastKey = "clear";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketQua = "0";
            changeResultScreen();
            lastKey = "clearEntry";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeSigned_Click(object sender, EventArgs e)
        {
            if (ketQua != "0")
            {
                if (ketQua[0] == '-') ketQua = ketQua.Substring(1);
                else ketQua = "-" + ketQua;
            }
            changeResultScreen();
            lastKey = "changeSigned";
        }

        private void btnResultScreen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            if (ketQua.IndexOf(',') == -1)
                ketQua += ",";
            changeResultScreen();
            lastKey = "float";
        }

        private void changeResultScreen()
        {
            btnResultScreen.Text = ketQua;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Memory = (double.Parse(Memory) + double.Parse(ketQua)).ToString();
            EnableMemory();
            lastKey = "memoryAdd";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ketQua = Memory;
            changeResultScreen();
            lastKey = "memoryReset";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Memory = "0";
            activeMemory = false;
            button8.Enabled = false;
            button6.Enabled = false;
            button10.Enabled = false;
            lastKey = "memoryClear";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Memory = (double.Parse(Memory) - double.Parse(ketQua)).ToString();
            EnableMemory();
            lastKey = "memorySubtract"
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Memory = ketQua;
            EnableMemory();
            lastKey = "memorySave";
        }

        private void EnableMemory() {
            if (!activeMemory)
            {
                button8.Enabled = true;
                button6.Enabled = true;
                button10.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketQua = (1 / double.Parse(ketQua)).ToString();
            changeResultScreen();
            lastKey = "divideFor1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ketQua = (double.Parse(ketQua) * double.Parse(ketQua)).ToString();
            changeResultScreen();
            lastKey = "sqr";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ketQua = (Math.Sqrt(double.Parse(ketQua))).ToString();
            changeResultScreen();
            lastKey = "sqrt";
        }

        private void btnMultiphy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
