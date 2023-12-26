namespace DBMSHomework
{
    partial class Runway
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
            this.airport = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.runwayno2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCmp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.runwayno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).BeginInit();
            this.SuspendLayout();
            // 
            // airport
            // 
            this.airport.FormattingEnabled = true;
            this.airport.Location = new System.Drawing.Point(170, 54);
            this.airport.Name = "airport";
            this.airport.Size = new System.Drawing.Size(200, 28);
            this.airport.TabIndex = 52;
            this.airport.SelectedIndexChanged += new System.EventHandler(this.airport_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 51;
            this.button4.Text = "ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // runwayno2
            // 
            this.runwayno2.Location = new System.Drawing.Point(400, 15);
            this.runwayno2.Name = "runwayno2";
            this.runwayno2.Size = new System.Drawing.Size(200, 27);
            this.runwayno2.TabIndex = 50;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 49;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 48;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Airport";
            // 
            // dataGridViewCmp
            // 
            this.dataGridViewCmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCmp.Location = new System.Drawing.Point(10, 385);
            this.dataGridViewCmp.Name = "dataGridViewCmp";
            this.dataGridViewCmp.RowHeadersWidth = 51;
            this.dataGridViewCmp.RowTemplate.Height = 29;
            this.dataGridViewCmp.Size = new System.Drawing.Size(980, 250);
            this.dataGridViewCmp.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runwayno
            // 
            this.runwayno.Location = new System.Drawing.Point(170, 15);
            this.runwayno.Name = "runwayno";
            this.runwayno.Size = new System.Drawing.Size(200, 27);
            this.runwayno.TabIndex = 44;
            this.runwayno.TextChanged += new System.EventHandler(this.cmpname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Runway No";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 29);
            this.button5.TabIndex = 53;
            this.button5.Text = "Hepsini Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Runway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.airport);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.runwayno2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runwayno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Runway";
            this.Text = "Runway";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox airport;
        private Button button4;
        private TextBox runwayno2;
        private Button button3;
        private Button button2;
        private Label label2;
        private DataGridView dataGridViewCmp;
        private Button button1;
        private TextBox runwayno;
        private Label label1;
        private Button button5;
    }
}