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
    public partial class add_level : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name, expert_id;
        public add_level(int add)
        {
            InitializeComponent();
            this.add = add;
        }
        public add_level(int add, string id, string name, string expert_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.expert_id = expert_id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update level set name='" + combolevel.SelectedItem + "',expert_id=" + comboexpert.SelectedValue.ToString() + " where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into level (name,expert_id) values('" + combolevel.SelectedItem + "'," + comboexpert.SelectedValue.ToString() + ")");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void add_level_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from expert");
            comboexpert.DataSource = dt_info;
            comboexpert.DisplayMember = "name";
            comboexpert.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل مستوى";
                button2.Text = "تعديل";
                combolevel.SelectedItem = name;
                comboexpert.SelectedValue = expert_id;
            }

            combolevel.Items.Add("المستوى الاول");
            combolevel.Items.Add("المستوى الثاني");
            combolevel.Items.Add("المستوى الثالث");
            combolevel.Items.Add("المستوى الرابع");
            combolevel.Items.Add("المستوى الخامس");
            combolevel.Items.Add("المستوى السادس");
        }
    }
}
