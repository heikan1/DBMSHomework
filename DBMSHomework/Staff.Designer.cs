namespace DBMSHomework
{
    partial class Staff
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
            this.staffno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffboss = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffmaas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staffno
            // 
            this.staffno.Location = new System.Drawing.Point(165, 12);
            this.staffno.Name = "staffno";
            this.staffno.Size = new System.Drawing.Size(173, 27);
            this.staffno.TabIndex = 0;
            this.staffno.TextChanged += new System.EventHandler(this.staffno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "staff no";
            // 
            // staffboss
            // 
            this.staffboss.FormattingEnabled = true;
            this.staffboss.Location = new System.Drawing.Point(165, 98);
            this.staffboss.Name = "staffboss";
            this.staffboss.Size = new System.Drawing.Size(173, 28);
            this.staffboss.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "maaş";
            // 
            // staffmaas
            // 
            this.staffmaas.Location = new System.Drawing.Point(165, 55);
            this.staffmaas.Name = "staffmaas";
            this.staffmaas.Size = new System.Drawing.Size(173, 27);
            this.staffmaas.TabIndex = 4;
            this.staffmaas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "boss";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(357, 185);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffmaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffboss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox staffno;
        public ComboBox staffboss;
        public TextBox staffmaas;
    }
}