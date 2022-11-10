using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 3,
                f1=1,
                f2=1,
                f3=1,
                istenen = (Convert.ToInt32(textBox1.Text));

            if (Convert.ToInt32(textBox1.Text) == 1)
                MessageBox.Show("1. eleman: 0");

            else if (Convert.ToInt32(textBox1.Text) == 2)
                MessageBox.Show("1. eleman: 1");

            for (;sayac<istenen;sayac++)
            {
                f3 = f1;
                f1 = f2;
                f2 = f1 + f3;
            }

            MessageBox.Show("serideki " + istenen + ". eleman: " + f2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Fibonacci serisinde bulmak istediğiniz sıra numarasını giriniz";

            button1.Text = "HESAPLA";

            this.BackColor = Color.AliceBlue;
        }
    }
}
