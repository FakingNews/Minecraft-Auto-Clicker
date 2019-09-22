using System;
using System.Threading;
using System.Windows.Forms;

namespace Notepad.exe
{
    public partial class Form1 : Form
    {

        private Thread countdownThread;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCPS_Click(object sender, EventArgs e)
        {

        }

        private void BunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = bunifuSlider1.Value.ToString("0");
        }

        private void BunifuSlider1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void TxtHotkey_Click(object sender, EventArgs e)
        {

        }
    }
}
