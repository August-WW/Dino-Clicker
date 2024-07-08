using System;
using System.Windows.Forms;

namespace Dino_Clicker
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickCount++;

            label1.Text = $"Clicks: {clickCount}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicks: 0";
            clickCount = 0;
        }
    }
}

// August, 2024