namespace library
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.book = new System.Windows.Forms.Button();
            this.article = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.Button();
            this.expert = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.Button();
            this.college = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.book);
            this.panel1.Controls.Add(this.article);
            this.panel1.Controls.Add(this.level);
            this.panel1.Controls.Add(this.expert);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.college);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 543);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "الترم";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "انشاء حساب مندوب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "تسجيل خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(7, 415);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(198, 43);
            this.book.TabIndex = 5;
            this.book.Text = "الكتب";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click_1);
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(7, 366);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(198, 43);
            this.article.TabIndex = 4;
            this.article.Text = "المواد";
            this.article.UseVisualStyleBackColor = true;
            this.article.Click += new System.EventHandler(this.article_Click);
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(7, 268);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(198, 43);
            this.level.TabIndex = 3;
            this.level.Text = "المستويات";
            this.level.UseVisualStyleBackColor = true;
            this.level.Click += new System.EventHandler(this.level_Click);
            // 
            // expert
            // 
            this.expert.Location = new System.Drawing.Point(7, 219);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(198, 43);
            this.expert.TabIndex = 2;
            this.expert.Text = "التخصصات";
            this.expert.UseVisualStyleBackColor = true;
            this.expert.Click += new System.EventHandler(this.expert_Click);
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(7, 170);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(198, 43);
            this.department.TabIndex = 1;
            this.department.Text = "الاقسام";
            this.department.UseVisualStyleBackColor = true;
            this.department.Click += new System.EventHandler(this.department_Click);
            // 
            // college
            // 
            this.college.Location = new System.Drawing.Point(7, 121);
            this.college.Name = "college";
            this.college.Size = new System.Drawing.Size(198, 43);
            this.college.TabIndex = 0;
            this.college.Text = "الكليات";
            this.college.UseVisualStyleBackColor = true;
            this.college.Click += new System.EventHandler(this.college_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::library.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(225, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(725, 543);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library.Properties.Resources.iconbook;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 567);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Text = "home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button article;
        private System.Windows.Forms.Button level;
        private System.Windows.Forms.Button expert;
        private System.Windows.Forms.Button department;
        private System.Windows.Forms.Button college;
    }
}