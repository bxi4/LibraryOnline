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
    public partial class Expert : Form
    {
        public Expert()
        {
            InitializeComponent();
        }

        private void Expert_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_Expert frm = new add_Expert(1);
            frm.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getdata();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `expert` d join departments c on d.departments_id=c.id where d.name like '%" + txtSearch.Text + "%'");
            dataGridView1.DataSource = dt;
        }
        public void getdata()
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `expert` d join departments c on d.departments_id=c.id");

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                add_Expert frm = new add_Expert(0, dataGridView1.Rows[row].Cells[2].Value.ToString(), dataGridView1.Rows[row].Cells[3].Value.ToString(), dataGridView1.Rows[row].Cells[4].Value.ToString());
                frm.ShowDialog();
            }
            else if (column == 1)
            {
                int i = conn.exesql("delete from expert where id =" + dataGridView1.Rows[row].Cells[2].Value.ToString() + "");
                if (i > 0)
                {
                    MessageBox.Show("تم الحذف");
                    getdata();
                }
            }

        }
    }
}
