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
    public partial class addcollege : Form
    {
        int add=1;//add 1 for add row add=0 for edit row
        string id, name;
        public addcollege(int add)
        {
            InitializeComponent();
            this.add = add;
        }
         public addcollege(int add,string id,string name)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
        }

        private void addcollege_Load(object sender, EventArgs e)
        {
            if (add == 0)
            {
                this.Text = "تعديل كلية";
                button1.Text = "تعديل";
                txtNameCollege.Text = name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update college set name='" + txtNameCollege.Text + "' where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into college (name) values('" + txtNameCollege.Text + "')");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void txtNameCollege_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
