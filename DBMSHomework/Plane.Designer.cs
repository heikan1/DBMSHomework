namespace DBMSHomework
{
    partial class Plane
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
            this.planeno2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.planeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPlane = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.planename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCmp = new System.Windows.Forms.ComboBox();
            this.comboBoxMf = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.planeno3 = new System.Windows.Forms.TextBox();
            this.planemodel3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // planeno2
            // 
            this.planeno2.Location = new System.Drawing.Point(369, 59);
            this.planeno2.Name = "planeno2";
            this.planeno2.Size = new System.Drawing.Size(194, 27);
            this.planeno2.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 17;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // planeno
            // 
            this.planeno.Location = new System.Drawing.Point(169, 59);
            this.planeno.Name = "planeno";
            this.planeno.Size = new System.Drawing.Size(194, 27);
            this.planeno.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Plane No";
            // 
            // dataGridViewPlane
            // 
            this.dataGridViewPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlane.Location = new System.Drawing.Point(10, 390);
            this.dataGridViewPlane.Name = "dataGridViewPlane";
            this.dataGridViewPlane.RowHeadersWidth = 51;
            this.dataGridViewPlane.RowTemplate.Height = 29;
            this.dataGridViewPlane.Size = new System.Drawing.Size(980, 250);
            this.dataGridViewPlane.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // planename
            // 
            this.planename.Location = new System.Drawing.Point(169, 22);
            this.planename.Name = "planename";
            this.planename.Size = new System.Drawing.Size(194, 27);
            this.planename.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plane Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manufacturer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Company Name";
            // 
            // comboBoxCmp
            // 
            this.comboBoxCmp.FormattingEnabled = true;
            this.comboBoxCmp.Location = new System.Drawing.Point(169, 134);
            this.comboBoxCmp.Name = "comboBoxCmp";
            this.comboBoxCmp.Size = new System.Drawing.Size(194, 28);
            this.comboBoxCmp.TabIndex = 23;
            this.comboBoxCmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxCmp_SelectedIndexChanged);
            // 
            // comboBoxMf
            // 
            this.comboBoxMf.FormattingEnabled = true;
            this.comboBoxMf.Location = new System.Drawing.Point(169, 174);
            this.comboBoxMf.Name = "comboBoxMf";
            this.comboBoxMf.Size = new System.Drawing.Size(194, 28);
            this.comboBoxMf.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 34;
            this.button5.Text = "Hepsini Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(169, 95);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(194, 27);
            this.capacity.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Capacity";
            // 
            // planeno3
            // 
            this.planeno3.Location = new System.Drawing.Point(569, 59);
            this.planeno3.Name = "planeno3";
            this.planeno3.Size = new System.Drawing.Size(194, 27);
            this.planeno3.TabIndex = 38;
            // 
            // planemodel3
            // 
            this.planemodel3.Location = new System.Drawing.Point(569, 22);
            this.planemodel3.Name = "planemodel3";
            this.planemodel3.Size = new System.Drawing.Size(194, 27);
            this.planemodel3.TabIndex = 37;
            // 
            // Plane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.planeno3);
            this.Controls.Add(this.planemodel3);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBoxMf);
            this.Controls.Add(this.comboBoxCmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.planeno2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.planeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPlane);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.planename);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Plane";
            this.Text = "Plane";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private TextBox planeno2;
        private Button button3;
        private Button button2;
        private TextBox planeno;
        private Label label2;
        private DataGridView dataGridViewPlane;
        private Button button1;
        private TextBox planename;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCmp;
        private ComboBox comboBoxMf;
        private Button button5;
        private TextBox capacity;
        private Label label5;
        private TextBox planeno3;
        private TextBox planemodel3;
    }
}