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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        string pheptinh;
        float data1, data2;
        private void OFFButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void so0_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "0";
        }
        private void so1_Click(object sender, EventArgs e)
        {
           
            HienThi.Text= HienThi.Text + "1";            
        }

        private void so2_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "2";
        }

        private void so3_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "3";
            data2 = Convert.ToInt16("3");     
        }

        private void so4_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "4";
        }

        private void so5_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "5";
        }

        private void so6_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "6";         
        }

        private void so7_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "7";
        }

        private void so8_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "8";
        }

        private void so9_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + "9";
        }
        private void Dau_cham_Click(object sender, EventArgs e)
        {
            HienThi.Text= HienThi.Text + ",";
        }
        private void Dau_nhan_Click(object sender, EventArgs e)
        { 
            pheptinh = "nhan";
            data1 = float.Parse(HienThi.Text);         
            HienThi.Clear();
        }

        private void Dau_cong_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            data1 = float.Parse(HienThi.Text);
            HienThi.Clear();
        }

        private void Dau_chia_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            data1 = float.Parse(HienThi.Text);          
            HienThi.Clear();
        }

        private void Dau_tru_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            data1 = float.Parse(HienThi.Text);
            HienThi.Clear();
            
        }
        
        private void Dau_Bang_Click(object sender, EventArgs e)
        {

            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(HienThi.Text);
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "x" + HienThi.Text + "=";
            }
            if (pheptinh == "chia")
            {
                data2 = data1 / float.Parse(HienThi.Text);
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "÷" + HienThi.Text + "=";
            }
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(HienThi.Text);
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "+" + HienThi.Text + "=";
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(HienThi.Text);
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "-" + HienThi.Text + "=";
            }
            if (pheptinh == "binhphuong")
            {
                data2 = data1 * data1;
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "^2"  + HienThi.Text + "=";
            }
            if (pheptinh == "luythua")
            {
                data2 = float.Parse(HienThi.Text);
                double kq = Math.Pow(data1, data2);
                KQ.Text = kq.ToString();
                HienThi.Text = data1.ToString() + "^"  + HienThi.Text + "=";
            }
            if (pheptinh == "nhan10")
            {
                data2 = data1 * 10;
                KQ.Text = data2.ToString();
                HienThi.Text = data1.ToString() + "x10" + "=";
            }          
        }

        private void DELButton_Click(object sender, EventArgs e)
        {
            if (HienThi.Text.Length > 0)
            {
                HienThi.Text = HienThi.Text.Remove(HienThi.Text.Length - 1, 1);
            }
            if (HienThi.Text.Length == 0)
            {
                HienThi.Text = "";
            }
        }

        private void BinhPhuongbutton_Click(object sender, EventArgs e)
        {
            pheptinh = "binhphuong";
            data1 = float.Parse(HienThi.Text);                
            HienThi.Clear();
        }

        private void MuXbutton_Click(object sender, EventArgs e)
        {
            pheptinh = "luythua";
            data1 = float.Parse(HienThi.Text);          
            HienThi.Clear();
        }

        private void KQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhan10button_Click(object sender, EventArgs e)
        {
            pheptinh="nhan10";
            data1 = float.Parse(HienThi.Text);
            HienThi.Clear();
        }

        private void HienThi_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ACbutton_Click(object sender, EventArgs e)
        {
            HienThi.Clear();
            KQ.Clear();
        }

       
    }
}
