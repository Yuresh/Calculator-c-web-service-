using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumerWS.YureWS;

namespace ConsumerWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Test2WebServiceSoapClient ws = new Test2WebServiceSoapClient();

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = ws.add(int.Parse(txtNum1.Text),int.Parse(txtNum2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = ws.mul(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = ws.sub(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = ws.div(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();

        }
    }
}
