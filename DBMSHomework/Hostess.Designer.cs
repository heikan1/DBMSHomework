namespace DBMSHomework
{
    partial class Hostess
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffmaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffboss = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffno = new System.Windows.Forms.TextBox();
            this.boy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "boy (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "boss";
            // 
            // staffmaas
            // 
            this.staffmaas.Location = new System.Drawing.Point(168, 61);
            this.staffmaas.Name = "staffmaas";
            this.staffmaas.Size = new System.Drawing.Size(173, 27);
            this.staffmaas.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "maaş";
            // 
            // staffboss
            // 
            this.staffboss.FormattingEnabled = true;
            this.staffboss.Location = new System.Drawing.Point(168, 94);
            this.staffboss.Name = "staffboss";
            this.staffboss.Size = new System.Drawing.Size(173, 28);
            this.staffboss.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "staff no";
            // 
            // staffno
            // 
            this.staffno.Location = new System.Drawing.Point(168, 28);
            this.staffno.Name = "staffno";
            this.staffno.Size = new System.Drawing.Size(173, 27);
            this.staffno.TabIndex = 16;
            // 
            // boy
            // 
            this.boy.Location = new System.Drawing.Point(168, 133);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(173, 27);
            this.boy.TabIndex = 24;
            // 
            // Hostess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(357, 185);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffmaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffboss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hostess";
            this.Text = "Hostess";
            this.Load += new System.EventHandler(this.Hostess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label3;
        public TextBox staffmaas;
        private Label label2;
        public ComboBox staffboss;
        private Label label1;
        public TextBox staffno;
        public TextBox boy;
    }
}