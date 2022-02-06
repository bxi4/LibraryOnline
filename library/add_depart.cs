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
    public partial class add_depart : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name, college_id;
        public add_depart(int add)
        {
            InitializeComponent();
            this.add = add;
        }
        public add_depart(int add, string id, string name, string college_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.college_id = college_id;
        }
        private void add_depart_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from college");
            comboCollege.DataSource = dt_info;
            comboCollege.DisplayMember = "name";
            comboCollege.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل قسم";
                button1.Text = "تعديل";
                txtNameDepartment.Text = name;
                comboCollege.SelectedValue = college_id;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update departments set name='" + txtNameDepartment.Text + "',college_id=" + comboCollege.SelectedValue.ToString() + " where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into departments (name,college_id) values('" + txtNameDepartment.Text + "'," + comboCollege.SelectedValue.ToString() + ")");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void comboCollege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
