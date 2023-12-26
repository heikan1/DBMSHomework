namespace DBMSHomework
{
    partial class Class
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
            this.button4 = new System.Windows.Forms.Button();
            this.cmpno2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmpno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCmp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmpname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 29;
            this.button4.Text = "ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmpno2
            // 
            this.cmpno2.Location = new System.Drawing.Point(400, 52);
            this.cmpno2.Name = "cmpno2";
            this.cmpno2.Size = new System.Drawing.Size(200, 27);
            this.cmpno2.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmpno
            // 
            this.cmpno.Location = new System.Drawing.Point(170, 52);
            this.cmpno.Name = "cmpno";
            this.cmpno.Size = new System.Drawing.Size(200, 27);
            this.cmpno.TabIndex = 25;
            this.cmpno.TextChanged += new System.EventHandler(this.cmpno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Class No";
            // 
            // dataGridViewCmp
            // 
            this.dataGridViewCmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmp.Location = new System.Drawing.Point(12, 388);
            this.dataGridViewCmp.Name = "dataGridViewCmp";
            this.dataGridViewCmp.RowHeadersWidth = 51;
            this.dataGridViewCmp.RowTemplate.Height = 29;
            this.dataGridViewCmp.Size = new System.Drawing.Size(980, 250);
            this.dataGridViewCmp.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmpname
            // 
            this.cmpname.Location = new System.Drawing.Point(170, 12);
            this.cmpname.Name = "cmpname";
            this.cmpname.Size = new System.Drawing.Size(200, 27);
            this.cmpname.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Class Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 30;
            this.button5.Text = "Hepsini Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmpno2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmpno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmpname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class";
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private TextBox cmpno2;
        private Button button3;
        private Button button2;
        private TextBox cmpno;
        private Label label2;
        private DataGridView dataGridViewCmp;
        private Button button1;
        private TextBox cmpname;
        private Label label1;
        private Button button5;
    }
}