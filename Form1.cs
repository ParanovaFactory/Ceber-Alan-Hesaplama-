using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çember_Alanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double yaricap, alan, cevre, pi;
            pi = 3.14;
            yaricap = Convert.ToDouble(textBox1.Text);
            alan = (yaricap * yaricap) * pi;
            cevre = 2 * yaricap * pi;
            label2.Text = alan.ToString();
            label3.Text = cevre.ToString();
        }
    }
}
