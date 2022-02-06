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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = conn.selectdata("select username,password from users where username='" + txtusername.Text + "'and password='" + txtpassword.Text + "'");
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("يرجى ادخال جميع الحقول");
                return;
            }
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل دخولك بنجاح");
                this.Hide();
                home hom = new home();
                hom.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("الرجاء التاكد من اسم المستخدم وكلمة المرور");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginrepres lr = new loginrepres();
            lr.ShowDialog();
            Close();
        }
    }
}
