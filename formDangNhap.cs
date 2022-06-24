using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP
{
    public partial class formDangNhap : Form
    {
       
        public formDangNhap()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                FormKTraThongTin Child = new FormKTraThongTin(textBox1.Text, textBox2.Text);
                FormMainGV Child2 = new FormMainGV();
                string sql = "select MK,MaQND from NguoiDung where MaND ='"+tk+"' and MK= '"+mk+"';";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dta = cmd.ExecuteReader();       
                if(dta.Read()==true)
                {
                    string l = dta["MaQND"].ToString();
                    
                    if (l=="112")
                    {
                        Child.Show();
                    }
                    else
                    {
                        Child2.Show(); 
                    }    
                }
                else
                {
                        Child.Hide();
                        MessageBox.Show("Đăng nhập thất bại!");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else 
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }

        
    }
}
