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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void chapter_Click(object sender, EventArgs e)
        {
            book bok = new book();
            bok.Show();
        }
    }
}
