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
   
    public partial class FormGiaoDienThi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KJNF2QE\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
        public string msv;
        public int TotalTime = 5;
        public int TotalTongCauHoi = 10;
        public int TongCauHoi = 5;
        int pos = 1;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt1 = new DataTable();


        public FormGiaoDienThi()
        {
            InitializeComponent();
        }
        public FormGiaoDienThi(string Message) : this()
        {
            conn.Open();
            
            msv = Message;
            string sql = "select Ten,MaND,NgaySinh from NguoiDung where  MaND ='"+msv+"';";
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read()==true)
            {
                label5.Text=dta["Ten"].ToString();
                label6.Text=dta["MaND"].ToString();
                label7.Text=dta["NgaySinh"].ToString();
                timer1.Start();
            }
            conn.Close();

        }
       
      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormGiaoDienThi_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            string h = "select * from CauHoi ";
            da = new SqlDataAdapter(h, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            
            string k = "select * from BaiLam ";
            da1 = new SqlDataAdapter(k, conn);
            dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);

            for (int i = 1; i<=TongCauHoi; i++)
            {
                dt.Rows[i]["CauHoiNum"]=i+1;
                dt1.Rows[i]["CauHoiSo"]=i+1;
            }                                       
            ShowCauHoi(pos);                     
        }
      
        private void ShowCauHoi(int CauHoiNum)
        {
            conn.Close();

            NoiDungCauHoi.Text="  Câu " +(CauHoiNum).ToString() + ": " +dt.Rows[CauHoiNum]["CauHoi"].ToString();
            lbAnsA.Text=dt.Rows[CauHoiNum]["OptionA"].ToString();
            lbAnsB.Text=dt.Rows[CauHoiNum]["OptionB"].ToString();
            conn.Open();
            if (dt.Rows[CauHoiNum]["OptionC"].ToString()=="")
            {
                lbAnsC.Visible=false;
                lbC.Visible=false;
            }    
            else
            {
                lbAnsC.Visible=true;
                lbC.Visible=true;
                lbAnsC.Text=dt.Rows[CauHoiNum]["OptionC"].ToString();
            }

            if (dt.Rows[CauHoiNum]["OptionD"].ToString()=="")
            {
                lbAnsD.Visible=false;
                lbD.Visible=false;
            }
            else
            {
                lbAnsD.Visible=true;
                lbD.Visible=true;
                lbAnsD.Text=dt.Rows[CauHoiNum]["OptionD"].ToString();
            }
         
            
        }
        /*private void ShowKetQua()
        { int kq=0;
            for (int i = 1; i<10; i++)
            {
                if (panel1.) ;
                {
                    kq=kq+1;
                }
            }
            MessageBox.Show(kq.ToString());
        }*/
           
       
        private void textBox3_Click(object sender, EventArgs e)
        {

        }       
       
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        int sec1 = 60;       
        int min1 = 4;
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec1--;
            if (sec1 == 0)
            {
                min1--;
                sec1=60;
                sec1--;
            }

            if (min1 < 0 )
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài thi");                
            }                      
            lbSec.Text= sec1.ToString();
            lbMin.Text= min1.ToString();
        }

        private void btPre_Click(object sender, EventArgs e)
        {
            if (this.btNopBai.Visible==false) return;
            if (pos == 1) return;
            pos--;                  
            ShowCauHoi(pos);

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (this.btNopBai.Visible==false) return;
            if (pos == TongCauHoi) return;
            pos++;                   
            ShowCauHoi(pos);
           
             
        }

        private void btNopBai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có muốn kết thúc bài thi hay không?", "Thông báo", MessageBoxButtons.YesNo) ==DialogResult.Yes)
                KetThucThi();
                //ShowKetQua();
        }
        private void KetThucThi()
        {
            Application.Exit();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            NoiDungCauHoi.Text="  Câu " +(1).ToString() + ": " +dt.Rows[1]["CauHoi"].ToString();
            lbAnsA.Text=dt.Rows[1]["OptionA"].ToString();
            lbAnsB.Text=dt.Rows[1]["OptionB"].ToString();
            lbAnsC.Text=dt.Rows[1]["OptionB"].ToString();
            lbAnsD.Text=dt.Rows[1]["OptionB"].ToString();
        }
    }
}
