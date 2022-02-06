using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class add_book : Form
    {
        int add = 1;//add 1 for add row add=0 for edit row
        string id, name,path_book,article_id;
        public add_book(int add)      
        {
            InitializeComponent();
             this.add = add;
        }
          public add_book(int add, string id, string name,string path_book, string article_id)
        {
            InitializeComponent();
            this.add = add;
            this.id = id;
            this.name = name;
            this.path_book = path_book;
            this.article_id = article_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
                int i = conn.exesql("update book set name='" + txtNamebook.Text + "', path_book= '" + txtNamepath.Text + "',chapter_id='" + comboarticle.SelectedValue.ToString() + "' where id ='" + id + "'");
                if (i > 0)
                {
                    MessageBox.Show("تم التعديل");
                }
            }
            else if (add == 1)
            {
                string[] arr = txtNamepath.Text.ToString().Split('\\');
                MessageBox.Show(arr[arr.Length - 1]);
                string file_name = arr[arr.Length - 1];
                int i = conn.exesql("insert into book (name,path_book,article_id) values('" + txtNamebook.Text + "','" + arr[arr.Length - 1] + "'," + comboarticle.SelectedValue.ToString() + ")");
                upload_using_ftp("ftp://127.0.0.1/", txtNamepath.Text, file_name, "mohammed", "1234");
                if (i > 0)
                {
                    MessageBox.Show("تم الإضافة");

                }
            }
        }
            private void upload_using_ftp(string server, string fpl, string fps, string ftp_user, string ftp_pass)
        {
            FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create(server + fps);
            ftpReq.UseBinary = true;
            ftpReq.Method = WebRequestMethods.Ftp.UploadFile;
            ftpReq.Credentials = new NetworkCredential(ftp_user, ftp_pass);

            byte[] b = File.ReadAllBytes(fpl);
            ftpReq.ContentLength = b.Length;
            using (Stream s = ftpReq.GetRequestStream())
            {
                s.Write(b, 0, b.Length);
            }

            FtpWebResponse ftpResp = (FtpWebResponse)ftpReq.GetResponse();

            if (ftpResp != null)
            {
                if (ftpResp.StatusDescription.StartsWith("226"))
                {
                   // Console.WriteLine("File Uploaded.");
                    MessageBox.Show("File Uploaded.");
                }
            }
        }

        private void add_book_Load(object sender, EventArgs e)
        {
            DataTable dt_info = conn.selectdata("select * from article");
            comboarticle.DataSource = dt_info;
            comboarticle.DisplayMember = "name";
            comboarticle.ValueMember = "id";
            if (add == 0)
            {
                this.Text = "تعديل الكتاب";
                button2.Text = "تعديل";
                txtNamebook.Text = name;
                comboarticle.SelectedValue = article_id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                txtNamepath.Text = fileName;
               // string[] arrAllFiles = ofd.FileNames;
                string[] arr = txtNamepath.Text.ToString().Split('\\');
                string file_name = arr[arr.Length - 1];
                
            }
        }
        }
    }

