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
    public partial class add_chapter : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name, level_id;
        public add_chapter(int add)
        {
            InitializeComponent();
            this.add = add;
        }
        public add_chapter(int add, string id, string name, string level_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.level_id = level_id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update chapter set name='" + comboNamechapter.SelectedItem + "',level_id=" + combolevel.SelectedValue.ToString() + " where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into chapter (name,level_id) values('" + comboNamechapter.SelectedItem + "'," + combolevel.SelectedValue.ToString() + ")");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void add_chapter_Load(object sender, EventArgs e)
        {
            comboNamechapter.Items.Add("الفصل الاول");
            comboNamechapter.Items.Add("الفصل الثاني");
            DataTable dt_info = conn.selectdata("select * from level");
            combolevel.DataSource = dt_info;
            combolevel.DisplayMember = "name";
            combolevel.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل الترم";
                button2.Text = "تعديل";
                combolevel.SelectedValue = level_id;
            }
            DataTable dt_infoo = conn.selectdata("select * from expert");
            comboBox1.DataSource = dt_infoo;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

        }
    }
}
