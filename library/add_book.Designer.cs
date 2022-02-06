namespace library
{
    partial class add_book
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamebook = new System.Windows.Forms.TextBox();
            this.txtNamepath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboarticle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "اسم الكتاب";
            // 
            // txtNamebook
            // 
            this.txtNamebook.Location = new System.Drawing.Point(122, 103);
            this.txtNamebook.Name = "txtNamebook";
            this.txtNamebook.Size = new System.Drawing.Size(241, 20);
            this.txtNamebook.TabIndex = 14;
            // 
            // txtNamepath
            // 
            this.txtNamepath.Location = new System.Drawing.Point(114, 239);
            this.txtNamepath.Name = "txtNamepath";
            this.txtNamepath.Size = new System.Drawing.Size(249, 20);
            this.txtNamepath.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(189, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "رفع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboarticle
            // 
            this.comboarticle.FormattingEnabled = true;
            this.comboarticle.Location = new System.Drawing.Point(122, 170);
            this.comboarticle.Name = "comboarticle";
            this.comboarticle.Size = new System.Drawing.Size(241, 21);
            this.comboarticle.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "المادة ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "مسار الكتاب";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(502, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamebook);
            this.Controls.Add(this.txtNamepath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboarticle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "add_book";
            this.Text = "add_book";
            this.Load += new System.EventHandler(this.add_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamebook;
        private System.Windows.Forms.TextBox txtNamepath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboarticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}