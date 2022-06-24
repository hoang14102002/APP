using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class TinhTongNsochan : Form
    {
        int a;
        
        public TinhTongNsochan()
        {
            InitializeComponent();
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a=Convert.ToInt16(textN.Text);
            if (a <0)
            {
                MessageBox.Show("Hãy nhập số N lớn hơn 0!", "Thông báo!");
            }
            else
            {
                int T=0;
                for (int i = 0; i <= a;i=i+2)
                {
                    T=T+i;
                    
                }

                MessageBox.Show(Convert.ToString(T), "Tổng của "+ a +" số tự nhiên đầu tiên là: ");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            a=Convert.ToInt16(textN.Text);
            if (a <0)
            {
                MessageBox.Show("Hãy nhập số N lớn hơn 0!", "Thông báo!");
            }
            else
            {
                int T=0;
                int i = 0;
                do
                {
                    T=T+i;
                    i=i+2;
                }
                while (i<=a);

                MessageBox.Show(Convert.ToString(T), "Tổng của "+ a +" số tự nhiên đầu tiên là: ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            a=Convert.ToInt16(textN.Text);
            if (a <0)
            {
                MessageBox.Show("Hãy nhập số N lớn hơn 0!","Thông báo!");
            }
            else
            {
                int T = 0;
                int i = 0;
                while (i<=a)
                {
                    T=T+i;
                    i=i+2;
                }

                MessageBox.Show(Convert.ToString(T), "Tổng của "+ a +" số tự nhiên đầu tiên là: ");
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
