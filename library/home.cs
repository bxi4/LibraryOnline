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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void college_Click(object sender, EventArgs e)
        {
            Form1 college = new Form1();
            college.ShowDialog();
        }

        private void department_Click(object sender, EventArgs e)
        {
            departments depart = new departments();
            depart.ShowDialog();
        }

        private void expert_Click(object sender, EventArgs e)
        {
            Expert expert = new Expert();
            expert.ShowDialog();
        }

        private void level_Click(object sender, EventArgs e)
        {
            level level = new level();
            level.ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            chapter chap = new chapter();
            chap.ShowDialog();
        }

        private void article_Click(object sender, EventArgs e)
        {
            article art = new article();
            art.ShowDialog();
        }

        private void book_Click_1(object sender, EventArgs e)
        {
            book bok = new book();
            bok.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            sginuprepres sginuprep = new sginuprepres();
            sginuprep.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
            Close();
        }
    }
}
