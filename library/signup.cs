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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void txtaddpassword_TextChanged(object sender, EventArgs e)
        {
            txtaddpassword.UseSystemPasswordChar = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtaddemail.Text == "" || txtaddusername.Text == "" || txtaddpassword.Text == "")
            {
                MessageBox.Show("يرجى ادخال جميع الحقول");
                return;
            }
            int add = conn.exesql("insert into users (email,username,password) values ('" + txtaddemail.Text + "','" + txtaddusername.Text + "','" + txtaddpassword.Text + "')");
            if (add == 1)
            {
                MessageBox.Show("تم التسجيل بنجاح");
            }
            else
            {
                MessageBox.Show("فشل التسجيل");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginrepres lorep = new loginrepres();
            lorep.ShowDialog();
        }
    }
}
