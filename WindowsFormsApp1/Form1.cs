using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int licznik = 0;

        private int sekundy = 0;
        public Form1()
        {
            InitializeComponent(); 
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            label1.Text = "Wynik:" + licznik;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sekundy++;
            label2.Text = sekundy.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
