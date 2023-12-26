namespace DBMSHomework
{
    partial class Person
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.personno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBoxListele = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "client",
            "passenger",
            "pilot",
            "hostess",
            "other staff"});
            this.comboBox1.Location = new System.Drawing.Point(170, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(663, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 51;
            this.button4.Text = "ara";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 49;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 48;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Person type";
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Location = new System.Drawing.Point(10, 385);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.RowHeadersWidth = 51;
            this.dataGridViewPerson.RowTemplate.Height = 29;
            this.dataGridViewPerson.Size = new System.Drawing.Size(980, 250);
            this.dataGridViewPerson.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personno
            // 
            this.personno.Location = new System.Drawing.Point(170, 15);
            this.personno.Name = "personno";
            this.personno.Size = new System.Drawing.Size(200, 27);
            this.personno.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Person No";
            // 
            // personname
            // 
            this.personname.Location = new System.Drawing.Point(170, 48);
            this.personname.Name = "personname";
            this.personname.Size = new System.Drawing.Size(200, 27);
            this.personname.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Person Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(13, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 185);
            this.panel1.TabIndex = 57;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 58;
            this.button5.Text = "Hepsini Listele =>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBoxListele
            // 
            this.comboBoxListele.FormattingEnabled = true;
            this.comboBoxListele.Items.AddRange(new object[] {
            "person",
            "client",
            "passenger",
            "staff",
            "pilot",
            "hostess"});
            this.comboBoxListele.Location = new System.Drawing.Point(170, 351);
            this.comboBoxListele.Name = "comboBoxListele";
            this.comboBoxListele.Size = new System.Drawing.Size(200, 28);
            this.comboBoxListele.TabIndex = 59;
            this.comboBoxListele.SelectedIndexChanged += new System.EventHandler(this.comboBoxListele_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "client",
            "passenger",
            "pilot",
            "hostess",
            "other staff"});
            this.comboBox2.Location = new System.Drawing.Point(557, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(400, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 185);
            this.panel2.TabIndex = 58;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxListele);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Person";
            this.Text = "Person";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private DataGridView dataGridViewPerson;
        private Button button1;
        private TextBox personno;
        private Label label1;
        private TextBox personname;
        private Label label4;
        private Panel panel1;
        private Button button5;
        private ComboBox comboBoxListele;
        private ComboBox comboBox2;
        private Panel panel2;
    }
}