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
    public partial class add_Expert : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name, departments_id;
        public add_Expert(int add)
        {
            InitializeComponent();
            this.add = add;
        }
        public add_Expert(int add, string id, string name, string departments_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.departments_id = departments_id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update expert set name='" + txtNameexpert.Text + "',departments_id=" + comboDepartment.SelectedValue.ToString() + " where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into expert (name,departments_id) values('" + txtNameexpert.Text + "'," + comboDepartment.SelectedValue.ToString() + ")");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void add_Expert_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from departments");
            comboDepartment.DataSource = dt_info;
            comboDepartment.DisplayMember = "name";
            comboDepartment.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل تخصص";
                button2.Text = "تعديل";
                txtNameexpert.Text = name;
                comboDepartment.SelectedValue = departments_id;
            }
        }
    }
}
