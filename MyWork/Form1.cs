using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            displayText.Text = "Hello Mactonio!";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            displayText.Text = "Bye Mactonio!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayText.Text = "Are You Ready!";
        }
    }
}
