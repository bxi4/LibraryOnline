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
    public partial class add_article : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name, chapter_id;
        public add_article(int add)
        {
            InitializeComponent();
            this.add = add;
        }
        public add_article(int add, string id, string name, string chapter_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.chapter_id = chapter_id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update article set name='" + txtNamearticle.Text + "',chapter_id=" + combochapter.SelectedValue.ToString() + " where id =" + id + "");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                int i = conn.exesql("insert into article (name,chapter_id) values('" + txtNamearticle.Text + "'," + combochapter.SelectedValue.ToString() + ")");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");
                }
            }
        }

        private void add_article_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from chapter");
            combochapter.DataSource = dt_info;
            combochapter.DisplayMember = "name";
            combochapter.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل المادة";
                button2.Text = "تعديل";
                txtNamearticle.Text = name;
                combochapter.SelectedValue = chapter_id;
            }
        }
    }
}
