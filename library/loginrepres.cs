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
    public partial class loginrepres : Form
    {
        public loginrepres()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            DataTable dt = conn.selectdata("select username,password from repres where username='" + txtusername.Text + "'and password='" + txtpassword.Text + "'");
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("يرجى ادخال جميع الحقول");
                return;
            }
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("تم تسجيل دخولك بنجاح");
                this.Hide();
                homerepres homres = new homerepres();
                homres.ShowDialog();

            }
            else
            {
                MessageBox.Show("الرجاء التاكد من اسم المستخدم وكلمة المرور");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lo = new login();
            lo.ShowDialog();
            Close();
        }

        private void loginrepres_Load(object sender, EventArgs e)
        {

        }
    }
}
