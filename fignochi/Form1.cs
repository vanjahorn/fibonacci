using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fignochi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = 0;
            int slut = 30;

            //hej christofer
               

            int prevprev = -1;
            int prev = 1;

            for (int i = start; i <= slut; i++)
            {
                int number = prevprev + prev;
                prevprev = prev;
                prev = number;

                textBox1.Text = textBox1.Text + number + " ";

            }
        }
    }
}
