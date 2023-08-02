using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenklerinDli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yönetici" && textBox2.Text == "12345") 
            {
                Form2 renk = new Form2();
                renk.Show();
                this.Hide();
            }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız Tekrar Deneyin!!!");
                    textBox1.Clear();
                    textBox2.Clear();
               
                }
        }   
    }
}
