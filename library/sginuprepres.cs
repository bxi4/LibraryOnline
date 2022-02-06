using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class sginuprepres : Form
    {
        public sginuprepres()
        {
            InitializeComponent();
        }

        private void txtaddpassword_TextChanged(object sender, EventArgs e)
        {
            txtaddpassword.UseSystemPasswordChar = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void sginuprepres_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from level");
            combolevel.DataSource = dt_info;
            combolevel.DisplayMember = "name";
            combolevel.ValueMember = "id";
        }

        private void sginup_Click_1(object sender, EventArgs e)
        {
            if (txtaddemail.Text == "" || txtaddusername.Text == "" || txtaddpassword.Text == "")
            {
                MessageBox.Show("يرجى ادخال جميع الحقول");
                return;
            }
            int add = conn.exesql("insert into repres (email,username,password) values ('" + txtaddemail.Text + "','" + txtaddusername.Text + "','" + txtaddpassword.Text + "')");
            if (add == 1)
            {
                MessageBox.Show("تم التسجيل بنجاح");
            }
            else
            {
                MessageBox.Show("فشل التسجيل");
            }
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginrepres lp = new loginrepres();
            lp.ShowDialog();
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login lo = new login();
            lo.ShowDialog();
            Close();
        }
    }
}
