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
    public partial class level : Form
    {
        public level()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `level` d join expert c on d.expert_id=c.id where d.name like '%" + txtSearch.Text + "%'");
            dataGridView1.DataSource = dt;
        }

        public void getdata()
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `level` d join expert c on d.expert_id=c.id");
            dataGridView1.DataSource = dt;
        }

        private void level_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_level frm = new add_level(1);
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                add_level frm = new add_level(0, dataGridView1.Rows[row].Cells[2].Value.ToString(), dataGridView1.Rows[row].Cells[3].Value.ToString(), dataGridView1.Rows[row].Cells[4].Value.ToString());
                frm.ShowDialog();
            }
            else if (column == 1)
            {
                int i = conn.exesql("delete from level where id =" + dataGridView1.Rows[row].Cells[2].Value.ToString() + "");
                if (i > 0)
                {
                    MessageBox.Show("تم الحذف");
                    getdata();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            getdata();
        }
    }
}

