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
    public partial class FormMainGV : Form
    {
        public FormMainGV()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status2.Text=System.DateTime.Now.ToString();
        }

        private void dlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f=new frmDMHH();
            f.Show();
        }

      
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
