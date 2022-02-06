using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void getdata()
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `book` d join article c on d.article_id=c.id");
            dataGridView1.DataSource = dt;
        }

        private void book_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_book frm = new add_book(1);
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            getdata();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column == 0)
            {
                add_book frm = new add_book(0, dataGridView1.Rows[row].Cells[2].Value.ToString(), dataGridView1.Rows[row].Cells[3].Value.ToString(), dataGridView1.Rows[row].Cells[4].Value.ToString(), dataGridView1.Rows[row].Cells[5].Value.ToString());
                frm.ShowDialog();
            }
            else if (column == 1)
            {
                int i = conn.exesql("delete from book where id =" + dataGridView1.Rows[row].Cells[2].Value.ToString() + "");
                if (i > 0)
                {
                    MessageBox.Show("تم الحذف");
                    getdata();
                }
            }
            else if (column == 2)
            {
                DataGridViewRow current_row = dataGridView1.Rows[row];
                string path = current_row.Cells["path_book"].Value.ToString();
                Byte[] ba = File.ReadAllBytes(@"C:\xampp\htdocs\" + path + "");
                string s = Encoding.Default.GetString(ba);
                Byte[] nba = Encoding.Default.GetBytes(s);
                File.WriteAllBytes(@"D:\don\" + path + ".pdf", nba);
                MessageBox.Show("تم تنزيل المقرر بنجاح");

            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = conn.selectdata("SELECT d.*,c.name FROM `book` d join article c on d.article_id=c.id where d.name like '%" + txtSearch.Text + "%'");
            dataGridView1.DataSource = dt;
        }
    }
}
