namespace DBMSHomework
{
    partial class Airport
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
            this.dataGridViewCmp = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.airpno2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.airpno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.airpname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCmp
            // 
            this.dataGridViewCmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmp.Location = new System.Drawing.Point(10, 390);
            this.dataGridViewCmp.Name = "dataGridViewCmp";
            this.dataGridViewCmp.RowHeadersWidth = 51;
            this.dataGridViewCmp.RowTemplate.Height = 29;
            this.dataGridViewCmp.Size = new System.Drawing.Size(980, 250);
            this.dataGridViewCmp.TabIndex = 23;
            this.dataGridViewCmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCmp_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 32;
            this.button4.Text = "ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // airpno2
            // 
            this.airpno2.Location = new System.Drawing.Point(403, 52);
            this.airpno2.Name = "airpno2";
            this.airpno2.Size = new System.Drawing.Size(200, 27);
            this.airpno2.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 30;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 29;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // airpno
            // 
            this.airpno.Location = new System.Drawing.Point(173, 52);
            this.airpno.Name = "airpno";
            this.airpno.Size = new System.Drawing.Size(200, 27);
            this.airpno.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Airport No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // airpname
            // 
            this.airpname.Location = new System.Drawing.Point(173, 12);
            this.airpname.Name = "airpname";
            this.airpname.Size = new System.Drawing.Size(200, 27);
            this.airpname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Airport Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 33;
            this.button5.Text = "Hepsini Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.airpno2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.airpno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.airpname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Airport";
            this.Text = "Airport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridViewCmp;
        private Button button4;
        private TextBox airpno2;
        private Button button3;
        private Button button2;
        private TextBox airpno;
        private Label label2;
        private Button button1;
        private TextBox airpname;
        private Label label1;
        private Button button5;
    }
}